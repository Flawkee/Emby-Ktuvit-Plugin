# Ktuvit Subtitle Plugin for Emby

## Overview

This project is a plugin for [Emby](https://emby.media/) that automatically downloads Hebrew subtitles from [Ktuvit.me](https://www.ktuvit.me) for movies and TV series.  
- **Movie subtitles** require Ktuvit.me login credentials (username and password).
- **Series subtitles** can be downloaded without credentials.

## Features

- Integrates with Emby’s subtitle search and download system.
- Supports Hebrew subtitles for both movies and TV series.
- Uses Ktuvit.me’s API (If you can call it that way...) for searching and downloading subtitles.
- Configuration options for Ktuvit.me credentials.

## Installation

1. Build the project using Visual Studio 2022 (.NET 8).
2. Place the compiled plugin DLL and resources in Emby’s `plugins` directory.
3. Restart Emby Server.
4. Configure the plugin in Emby’s web interface under __Settings > Plugins > Ktuvit__.

## Configuration

- **Username**: Your email address registered on Ktuvit.me.
- **Password**: Your Ktuvit.me password.
- Credentials are only required for movie subtitles. Leave blank to enable series subtitles only.

## Usage

1. Search for subtitles in Emby as usual.
2. Select Hebrew subtitles from Ktuvit.me in the results.
3. Download and apply subtitles to your media.

## License

This project is licensed under the [MIT License](LICENSE).

---

**Ktuvit Subtitle Plugin**  
Automatically downloads Hebrew subtitles for your Emby media library.
