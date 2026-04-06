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

## How to set up a GitHub Plugin Repository

You can serve this plugin globally to others by deploying a GitHub "Repository Manifest":

1. **Push your code to GitHub**: Setup your `git` repo and push all these files.
2. **Setup the built-in GitHub Actions workflow**: The repo contains a `.github/workflows/build.yml` file. When you push a Git tag formatted with a `v` (e.g. `git tag -a v1.0.0 -m "Release v1.0.0"` followed by `git push origin v1.0.0`), GitHub will automatically compile your project and attach `M4bEnhancer.zip` directly to your GitHub Releases.
3. **Configure the `manifest.json` file**: Use the enclosed `manifest.json`. 
4. Calculate the MD5 Hash of the published `M4bEnhancer.zip` and add it to `checksum` in the `manifest.json`.
5. Point your Jellyfin Server to this plugin! Navigate to **Dashboard -> Plugins -> Repositories** and click Add. Give it a name and use the `Raw` URL to your GitHub `manifest.json` file:
   `https://raw.githubusercontent.com/jensul/Jellyfin-m4b-Plugin/main/manifest.json`
   Jellyfin will then beautifully present the plugin for automatic web installation dynamically.
