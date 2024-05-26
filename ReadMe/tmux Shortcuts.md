# TMUX Shortcuts

| **Category**          | **Action**                          | **Shortcut**            |
|-----------------------|-------------------------------------|-------------------------|
| **Session Management**| Create a new session                | `tmux new -s session_name` |
|                       | Detach from session                 | `Ctrl+b d`              |
|                       | List sessions                       | `tmux ls`               |
|                       | Attach to a session                 | `tmux attach -t session_name` |
|                       | Kill a session                      | `tmux kill-session -t session_name` |
| **Window Management** | Create a new window                 | `Ctrl+b c`              |
|                       | Switch to next window               | `Ctrl+b n`              |
|                       | Switch to previous window           | `Ctrl+b p`              |
|                       | Rename the current window           | `Ctrl+b ,`              |
|                       | Close the current window            | `Ctrl+b &`              |
| **Pane Management**   | Split window horizontally           | `Ctrl+b "`              |
|                       | Split window vertically             | `Ctrl+b %`              |
|                       | Switch to the next pane             | `Ctrl+b o`              |
|                       | Switch to the previous pane         | `Ctrl+b ;`              |
|                       | Toggle between panes                | `Ctrl+b Ctrl+o`         |
|                       | Move to pane (up, down, left, right)| `Ctrl+b` + arrow key    |
|                       | Resize pane                         | `Ctrl+b` + hold arrow key |
|                       | Close the current pane              | `Ctrl+b x`              |
| **Miscellaneous**     | Show shortcuts                      | `Ctrl+b ?`              |
|                       | Reload config                       | `Ctrl+b :` then `source-file ~/.tmux.conf` |
|                       | Copy mode                           | `Ctrl+b [` (enter), `q` (exit) |
|                       | Scroll up/down in copy mode         | `Ctrl+b [` then arrow keys or `PgUp`/`PgDn` |
