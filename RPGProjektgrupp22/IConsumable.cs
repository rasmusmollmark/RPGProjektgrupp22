namespace RPGProjektgrupp22
{
    // 1: Här används konceptet interface
    // 2: Det används genom att skapa en mall för alla "förbrukningsföremål"
    // 3: Det används för att det då blir som ett kontrakt där alla klasser som implementerar interfacet måste ha med dessa fält och metoder
    public interface IConsumable
    {
        public string ConsumableToString();
        public int Price { get; set; }
        public string Type { get; set; }
    }
}