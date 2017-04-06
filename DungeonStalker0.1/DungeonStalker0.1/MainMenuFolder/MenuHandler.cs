using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using DungeonStalker0._1.MainMenuFolder;

namespace DungeonStalker0._1.MainMenuFolder
{
    class MenuHandler
    {
        GraphicsDevice g;
        ContentManager Content;

        MainMenu mainMenu = null;
        OptionMenu optionMenu = null;

        public enum MenuState
        {
            MainMenu,
            OptionsMenu
        }
        public static MenuState menuState = MenuState.OptionsMenu;

        public MenuHandler(GraphicsDevice g, ContentManager Content)
        {
            this.g = g;
            this.Content = Content;
        }

        public void Update()
        {
            switch (menuState)
            {
                case MenuState.MainMenu:
                    if (mainMenu == null)
                    {
                        mainMenu = new MainMenu(g, Content);
                        optionMenu = null;
                    }

                    mainMenu.Update();
                    break;
                case MenuState.OptionsMenu:
                    if (optionMenu == null)
                    {
                        optionMenu = new OptionMenu(g, Content);
                        mainMenu = null;
                    }

                    optionMenu.Update();
                    break;
                default:
                    break;
            }
        }

        
        public void Draw(SpriteBatch spriteBatch)
        {
            switch (menuState)
            {
                case MenuState.MainMenu:
                    if (mainMenu != null)
                        mainMenu.Draw(spriteBatch);
                    break;
                case MenuState.OptionsMenu:
                    if (optionMenu != null)
                        optionMenu.Draw(spriteBatch);
                    break;
                default:
                    break;
            }
        }


    }
}
