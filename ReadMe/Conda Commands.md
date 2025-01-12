
# Most Used Conda Commands

## Environment Management
- **Create a new environment**:  
  `conda create --name env_name`
  
- **List all environments**:  
  `conda env list` or `conda info --envs`
  
- **Activate an environment**:  
  `conda activate env_name`
  
- **Deactivate the current environment**:  
  `conda deactivate`
  
- **Remove an environment**:  
  `conda remove --name env_name --all`

## Package Management
- **Install a package**:  
  `conda install package_name`
  
- **Install a specific version of a package**:  
  `conda install package_name=version`
  
- **Install from a specific channel**:  
  `conda install -c channel_name package_name`
  
- **List all installed packages**:  
  `conda list`
  
- **Update a package**:  
  `conda update package_name`
  
- **Update all packages in the environment**:  
  `conda update --all`
  
- **Remove a package**:  
  `conda remove package_name`

## Configuration and Troubleshooting
- **Search for a package**:  
  `conda search package_name`
  
- **Check the conda configuration**:  
  `conda config --show`
  
- **Add a new channel**:  
  `conda config --add channels channel_name`
  
- **Remove a channel**:  
  `conda config --remove channels channel_name`
  
- **Clean unused packages and cache**:  
  `conda clean --all`

## Miscellaneous
- **Export environment to a YAML file**:  
  `conda env export > environment.yml`
  
- **Create an environment from a YAML file**:  
  `conda env create --file environment.yml`
  
- **Get help for a specific command**:  
  `conda help command` (e.g., `conda help install`)
