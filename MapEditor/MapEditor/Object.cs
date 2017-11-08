using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapEditor
{
    class GameObject
    {
        public enum EObjectID
        {
            GROUND,
            ROPE,
            WALL,
            LEVERAGE,
            COLUMN,
            BAR,
     
            CAMEL,

            GUARDS1,
            GUARDS2,
            GUARDS3,

            CIVILIAN1,
            CIVILIAN2,
            CIVILIAN3,
            CIVILIAN4,

            PEDDLER,

            APPLEITEM,
            TEAPOTITEM,
            GENIEITEM,
            BALLITEM,
            ALADDINITEM,
            HEARTITEM,
            MONKEYITEM,
            JARITEM,
            STAIR,
            NONE
        }

        private int _width;
        private int _height;
        private int _x;
        private int _y;
        private EObjectID _id;
        private int _key;

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        internal EObjectID Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public int Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
            }
        }

        public GameObject()
        {
        }

        public GameObject(int x, int y, int width, int height, EObjectID id)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Id = id;
        }
    }
}
