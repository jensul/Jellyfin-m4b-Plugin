# M4B Audiobook Enhancer for Jellyfin

This plugin enhances metadata extraction and chapter reading natively in Jellyfin for `.m4b` Audiobooks. It reads embedded Tags, Albums, Chapters, and distinct Narrators seamlessly.

## How to Install Manually

Installing plugin manually requires you to place the compiled `.dll` output directly into your Jellyfin `plugins` folder.

1. Publish the code to folder:
   ```bash
   dotnet publish -c Release -o out
   ```
2. Navigate to your Jellyfin Server's Data directory.
   - **Linux/Docker**: `/config/plugins` or `/var/lib/jellyfin/plugins`
   - **Windows**: `C:\ProgramData\Jellyfin\Server\plugins`
   - **macOS (Homebrew)**: `~/.local/share/jellyfin/plugins`
3. Create a folder named `M4bEnhancer` inside `plugins/`.
4. Copy ALL files generated inside the `out/` folder (which includes `M4bEnhancer.dll` and `ATL.dll`) to your newly created `M4bEnhancer` folder.
5. **Restart** your Jellyfin Server.
6. The plugin will appear in **Dashboard -> Plugins**. You can then rescan your Audiobook Media Libraries.

## 🌐 Add to Jellyfin via GitHub Repository (Recommended)

Since this repository is already fully configured with GitHub Actions, you can instantly install and update the plugin directly from your Jellyfin Dashboard!

1. Open your Jellyfin server and navigate to **Dashboard -> Plugins -> Repositories**.
2. Click the **+** (Add) button.
3. Enter a name (e.g., `M4B Enhancer Catalog`).
4. Copy and paste the following exact URL into the **Repository URL** field:
   
   ```text
   https://raw.githubusercontent.com/jensul/Jellyfin-m4b-Plugin/main/manifest.json
   ```

5. Click Save. Now click over to your **Catalog** tab, and you will find the `M4B Audiobook Enhancer` ready for 1-click installation!

---

### How to release a new update
If you make code changes in the future and want to push an update:
1. Push your code.
2. Push a new tag `git tag -a v1.0.3 -m "Update"` & `git push origin v1.0.3`.
3. Wait for the GitHub Action to finish creating the zip. Download it and generate its MD5 hash.
4. Open `manifest.json`, duplicate the version block at the top, change the version number, add the new checksum, and push! Jellyfin will automatically see the new version!
