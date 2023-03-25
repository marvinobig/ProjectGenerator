# ProjectGenerator

Console Application to Generate Boilerplate Content For Vanilla Web Projects.

## Avaliable Commmands
- `vanilla-web <project-name>`: generates boilerplate for vanilla web projects (HTML/CSS/JS)

## Command Function 
The command `vanilla-web <project-name>` will create 3 directories (js/css/assets) and will 
also create the main html index file with boilerplate code included. It will also create three 
additional files which include 'css/reset.css', 'css/<project-name>.css' & js/<project-name>.js.
Also, within the 'css/reset.css' file, boilerplate css is added so projects have all browser default 
css removed to enable easier styling. All the files created except the main index.html file will be 
linked within the index.html file within the boilerplate code.
