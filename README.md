
# 🧹 AntiVis (Anti Visual Indexes)

A lightweight yet powerful **C# Console Application** designed to automatically remove specific text patterns (“indexes”) from `.sql` and `.txt` files.

AntiVis helps developers and database administrators streamline workflows by eliminating repetitive manual cleanup. Includes a persistent clipboard feature so cleaned text is available instantly — even after the app closes.

---

## 🚀 Features

### 🔍 Targeted Removal
Remove any specific string or index from a file instantly.

### 📁 Smart Path Detection
The program automatically checks if your file is in the local directory or requires a full path.

### 📤 Flexible Output Options
Choose how you want to handle the cleaned text:
- 💾 **Save to a New File** — preserve the original  
- 📝 **Overwrite Existing File** — apply changes directly  
- 📋 **Copy to Clipboard** — text stays saved even after exit  

### 🎨 Visual Interface
Custom ASCII-styled UI for a clean, readable console experience.

---

## 📥 Installation & Usage (No Coding Required)

1. Go to the **[Releases](../../releases)** section.
2. Download the latest `.zip` or `.exe`.
3. Run `AntiVis.exe`.
4. Follow the on-screen steps:
   - **Step 1:** Enter the text/index you want to remove  
   - **Step 2:** Provide the filename (e.g., `database.sql`)  
   - **Step 3:** Select your preferred output option  

---

## 💻 Building from Source (Developers)

If you'd like to contribute or modify the program:

### 1. Clone the repo

```bash
git clone https://github.com/JUSICK/AntiVis.git
````

### 2. Open the project

Open `deleting_visible.csproj` using Visual Studio or VS Code.

### 3. Build & run

Windows is required due to clipboard functionality.

```bash
dotnet run
```

---

## 📝 Example

**Input file (`data.sql`):**

```sql
CREATE INDEX index_heavy ON Users;
SELECT * FROM Users;
```

**Action performed:**

* Text to remove: `CREATE INDEX index_heavy ON Users;`
* Output mode: **3 — Copy to Clipboard**

**Clipboard result:**

```sql
SELECT * FROM Users;
```

---

## ⚖️ License

This project is distributed under the **MIT License**. See the `LICENSE` file for details.

---

## 👤 Author

**Illia Kuchuhurniy**

---
_Created as a portfolio project to demonstrate File I/O, Process Management, and Clipboard interaction in C#._
