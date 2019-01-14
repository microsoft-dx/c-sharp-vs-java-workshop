using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopMSP
{
    public class BaseModel
    {
        #region Get / Set
        /* 
            Cele 3 variante sunt echivalente 
        */

        // ********** Varianta 1 - Java Style **********
        private int _id; 

        public int GetId()
        {
            return _id;
        }

        public void SetId(int _value)
        {
            this._id = _value;
        }

        // ********** Varianta 2 **********
        private int _baseId;

        public int BaseId {
            get { return this._baseId; }
            set { this._baseId = value; }
        }

        // ********** Varianta 3 **********
        public int ExtendedId { get; set; }
        #endregion

    }
}
