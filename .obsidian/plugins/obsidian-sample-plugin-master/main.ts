import { App, Modal, Plugin, PluginSettingTab, Setting, TFile } from 'obsidian';

interface MyPluginSettings {
	mySetting: string;
}

const DEFAULT_SETTINGS: MyPluginSettings = {
	mySetting: 'MyFolder', // default folder
};

export default class XmlExportPlugin extends Plugin {
	settings: MyPluginSettings;

	async onload() {
		await this.loadSettings();

		// Ribbon icon to generate XML using folder from settings
		this.addRibbonIcon('dice', 'Generate XML', () => {
			const folderPath = this.settings.mySetting;
			const xml = this.generateXmlFromFolder(folderPath);
			new XmlModal(this.app, xml).open();
		});

		// Settings tab to change folder
		this.addSettingTab(new SampleSettingTab(this.app, this));
	}

	async loadSettings() {
		this.settings = Object.assign({}, DEFAULT_SETTINGS, await this.loadData());
	}

	async saveSettings() {
		await this.saveData(this.settings);
	}

	generateXmlFromFolder(folderPath: string): string {
		const files = this.app.vault.getFiles().filter(f => f.path.startsWith(folderPath + "/"));
		const xmlList: string[] = [];

		for (const file of files) {
			const cache = this.app.metadataCache.getFileCache(file);
			if (cache?.frontmatter) {
				const xml = this.frontmatterToXml(cache.frontmatter, file.name);
				if (xml) xmlList.push(xml);
			}
		}

		let xml = '<?xml version="1.0"?>\n' +
			'<compendium xmlns:exsl="http://exslt.org/common" version="5" auto_indent="NO">\n';

		for (const x of xmlList) {
			xml += `${x}\n`;
		}

		xml += '</compendium>';
		return xml;
	}

	frontmatterToXml(frontmatter: Record<string, any>, fileName: string): string | null {
		if (frontmatter.export === false) return null;
		let xml = `<item>\n`;

		for (const key in frontmatter) {
			if (key === "position" || key === "owner" || key ==="export") continue;
			const value = frontmatter[key];

			if (key.startsWith("modifier_")) {
				const category = key.split("_")[1] ?? "unknown";
				if (Array.isArray(value)) {
					for (const v of value) {
						xml += `  <modifier category="${category}">${this.escapeXml(v)}</modifier>\n`;
					}
				} else {
					xml += `  <modifier category="${category}">${this.escapeXml(value)}</modifier>\n`;
				}
				continue;
			}

			if (Array.isArray(value)) {
				for (const v of value) {
					xml += `  <${key}>${this.escapeXml(v)}</${key}>\n`;
				}
				continue;
			}

			xml += `  <${key}>${this.escapeXml(value)}</${key}>\n`;
		}

		xml += `</item>\n`;
		return xml;
	}

	escapeXml(str: any): string {
		if (str == null) return "";
		return String(str)
			.replace(/&/g, "&amp;")
			.replace(/</g, "&lt;")
			.replace(/>/g, "&gt;")
			.replace(/"/g, "&quot;")
			.replace(/'/g, "&apos;");
	}
}

class XmlModal extends Modal {
	content: string;

	constructor(app: App, content: string) {
		super(app);
		this.content = content;
	}

	onOpen() {
		const { contentEl } = this;
		contentEl.createEl("h2", { text: "Generated XML" });

		const textarea = contentEl.createEl("textarea", { text: this.content });
		textarea.style.width = "100%";
		textarea.style.height = "300px";

		// Copy button
		const copyBtn = contentEl.createEl("button", { text: "Copy to clipboard" });
		copyBtn.style.marginRight = "10px";
		copyBtn.onclick = () => {
			navigator.clipboard.writeText(this.content);
			alert("XML copied!");
		};

		// Save button
		const saveBtn = contentEl.createEl("button", { text: "Save to vault" });
		saveBtn.onclick = async () => {
			const folder = "ExportedXML"; // folder in your vault
			const fileName = `brumster_compendium.xml`; // fixed file name
			const filePath = `${folder}/${fileName}`;

			// Ensure folder exists
			await this.app.vault.createFolder(folder).catch(() => { });

			// Check if file exists

			const existingFile = this.app.vault.getAbstractFileByPath(filePath);

			if (existingFile instanceof TFile) {
				// Overwrite
				await this.app.vault.modify(existingFile, this.content);
				alert(`XML overwritten at ${filePath}`);
			} else {
				// Create new file
				await this.app.vault.create(filePath, this.content);
				alert(`XML saved to ${filePath}`);
			}
		};
	}

	onClose() {
		this.contentEl.empty();
	}
}


// Settings tab
class SampleSettingTab extends PluginSettingTab {
	plugin: XmlExportPlugin;

	constructor(app: App, plugin: XmlExportPlugin) {
		super(app, plugin);
		this.plugin = plugin;
	}

	display(): void {
		const { containerEl } = this;
		containerEl.empty();

		new Setting(containerEl)
			.setName("Folder path")
			.setDesc("Folder inside your vault to generate XML from")
			.addText(text => text
				.setPlaceholder("Enter folder path")
				.setValue(this.plugin.settings.mySetting)
				.onChange(async (value) => {
					this.plugin.settings.mySetting = value;
					await this.plugin.saveSettings();
				}));
	}
}
