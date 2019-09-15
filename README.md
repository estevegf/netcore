# React & Next Project

This project was generated with:
- `dotnet new webapp -o netcore-project`

## Development server

- Run `dotnet run` for a dev server. 
- Navigate to `https://localhost:5000/`.
- To reload any change: `ctrl + shift + r`.

## Deployment Self Contained
- `dotnet publish -c Release -r linux-x64 --self-contained true`
- `scp -r .\bin\Release\netcoreapp2.2\linux-x64\publish <user>@<domain>:/home/<user>/netcoreapp2.2`
- `ssh <user>@<domain>`
- `mv netcoreapp2.2 /var/www/<folder-domain>/netcore-project`
- `cd /var/www`
- `sudo chown -R www-data:www-data <folder-domain>/`
- `cd /var/www/<folder-domain>/netcore-project`
- `dotnet netcore-project.dll`
- Create a service 