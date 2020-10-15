using Store.Model;
using System.Collections.Generic;

namespace Store.Service
{
    /// <summary>
    /// GadgetSerive operations that we want to expose
    /// </summary>
    public interface IGadgetService
    {
        IEnumerable<Gadget> GetGadgets();
        IEnumerable<Gadget> GetCategoryGadgets(string categoryName, string gadgetName = null);
        Gadget GetGadget(int id);
        void CreateGadget(Gadget gadget);
        void SaveGadget();
    }
}
