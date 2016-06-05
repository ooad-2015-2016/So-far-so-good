﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace JobRadar
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::JobRadar.JobRadar_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::JobRadar.JobRadar_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::JobRadar.JobRadar_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace JobRadar.JobRadar_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[25];
            _typeNameTable[0] = "Windows.UI.Color";
            _typeNameTable[1] = "System.ValueType";
            _typeNameTable[2] = "Object";
            _typeNameTable[3] = "Byte";
            _typeNameTable[4] = "JobRadar.Help";
            _typeNameTable[5] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[6] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[7] = "JobRadar.HomePage";
            _typeNameTable[8] = "System.Collections.ObjectModel.ObservableCollection`1<JobRadar.JobRadarBaza.Models.Konkurs>";
            _typeNameTable[9] = "System.Collections.ObjectModel.Collection`1<JobRadar.JobRadarBaza.Models.Konkurs>";
            _typeNameTable[10] = "JobRadar.JobRadarBaza.Models.Konkurs";
            _typeNameTable[11] = "Int32";
            _typeNameTable[12] = "JobRadar.LogInForma";
            _typeNameTable[13] = "System.Windows.Input.ICommand";
            _typeNameTable[14] = "JobRadar.Pocetna";
            _typeNameTable[15] = "JobRadar.PocetnaRegistracija";
            _typeNameTable[16] = "JobRadar.PregledKonkursa";
            _typeNameTable[17] = "JobRadar.ProfilPoslodavca";
            _typeNameTable[18] = "JobRadar.Registracija2Forma";
            _typeNameTable[19] = "JobRadar.RegistracijaForma";
            _typeNameTable[20] = "JobRadar.ProfilNezaposlenog";
            _typeNameTable[21] = "JobRadar.Registracija3Forma";
            _typeNameTable[22] = "JobRadar.RegistracijaPoslodavca";
            _typeNameTable[23] = "JobRadar.UnosKonkursa";
            _typeNameTable[24] = "JobRadar.MainPage";

            _typeTable = new global::System.Type[25];
            _typeTable[0] = typeof(global::Windows.UI.Color);
            _typeTable[1] = typeof(global::System.ValueType);
            _typeTable[2] = typeof(global::System.Object);
            _typeTable[3] = typeof(global::System.Byte);
            _typeTable[4] = typeof(global::JobRadar.Help);
            _typeTable[5] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[6] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[7] = typeof(global::JobRadar.HomePage);
            _typeTable[8] = typeof(global::System.Collections.ObjectModel.ObservableCollection<global::JobRadar.JobRadarBaza.Models.Konkurs>);
            _typeTable[9] = typeof(global::System.Collections.ObjectModel.Collection<global::JobRadar.JobRadarBaza.Models.Konkurs>);
            _typeTable[10] = typeof(global::JobRadar.JobRadarBaza.Models.Konkurs);
            _typeTable[11] = typeof(global::System.Int32);
            _typeTable[12] = typeof(global::JobRadar.LogInForma);
            _typeTable[13] = typeof(global::System.Windows.Input.ICommand);
            _typeTable[14] = typeof(global::JobRadar.Pocetna);
            _typeTable[15] = typeof(global::JobRadar.PocetnaRegistracija);
            _typeTable[16] = typeof(global::JobRadar.PregledKonkursa);
            _typeTable[17] = typeof(global::JobRadar.ProfilPoslodavca);
            _typeTable[18] = typeof(global::JobRadar.Registracija2Forma);
            _typeTable[19] = typeof(global::JobRadar.RegistracijaForma);
            _typeTable[20] = typeof(global::JobRadar.ProfilNezaposlenog);
            _typeTable[21] = typeof(global::JobRadar.Registracija3Forma);
            _typeTable[22] = typeof(global::JobRadar.RegistracijaPoslodavca);
            _typeTable[23] = typeof(global::JobRadar.UnosKonkursa);
            _typeTable[24] = typeof(global::JobRadar.MainPage);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_4_Help() { return new global::JobRadar.Help(); }
        private object Activate_7_HomePage() { return new global::JobRadar.HomePage(); }
        private object Activate_8_ObservableCollection() { return new global::System.Collections.ObjectModel.ObservableCollection<global::JobRadar.JobRadarBaza.Models.Konkurs>(); }
        private object Activate_9_Collection() { return new global::System.Collections.ObjectModel.Collection<global::JobRadar.JobRadarBaza.Models.Konkurs>(); }
        private object Activate_12_LogInForma() { return new global::JobRadar.LogInForma(); }
        private object Activate_14_Pocetna() { return new global::JobRadar.Pocetna(); }
        private object Activate_15_PocetnaRegistracija() { return new global::JobRadar.PocetnaRegistracija(); }
        private object Activate_16_PregledKonkursa() { return new global::JobRadar.PregledKonkursa(); }
        private object Activate_17_ProfilPoslodavca() { return new global::JobRadar.ProfilPoslodavca(); }
        private object Activate_18_Registracija2Forma() { return new global::JobRadar.Registracija2Forma(); }
        private object Activate_19_RegistracijaForma() { return new global::JobRadar.RegistracijaForma(); }
        private object Activate_20_ProfilNezaposlenog() { return new global::JobRadar.ProfilNezaposlenog(); }
        private object Activate_21_Registracija3Forma() { return new global::JobRadar.Registracija3Forma(); }
        private object Activate_22_RegistracijaPoslodavca() { return new global::JobRadar.RegistracijaPoslodavca(); }
        private object Activate_23_UnosKonkursa() { return new global::JobRadar.UnosKonkursa(); }
        private object Activate_24_MainPage() { return new global::JobRadar.MainPage(); }
        private void VectorAdd_8_ObservableCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::JobRadar.JobRadarBaza.Models.Konkurs>)instance;
            var newItem = (global::JobRadar.JobRadarBaza.Models.Konkurs)item;
            collection.Add(newItem);
        }
        private void VectorAdd_9_Collection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::JobRadar.JobRadarBaza.Models.Konkurs>)instance;
            var newItem = (global::JobRadar.JobRadarBaza.Models.Konkurs)item;
            collection.Add(newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::JobRadar.JobRadar_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  Windows.UI.Color
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                userType.AddMemberName("A");
                userType.AddMemberName("B");
                userType.AddMemberName("G");
                userType.AddMemberName("R");
                xamlType = userType;
                break;

            case 1:   //  System.ValueType
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case 2:   //  Object
                xamlType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  Byte
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 4:   //  JobRadar.Help
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_4_Help;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  JobRadar.HomePage
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_HomePage;
                userType.AddMemberName("Konkursi");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  System.Collections.ObjectModel.ObservableCollection`1<JobRadar.JobRadarBaza.Models.Konkurs>
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<JobRadar.JobRadarBaza.Models.Konkurs>"));
                userType.CollectionAdd = VectorAdd_8_ObservableCollection;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 9:   //  System.Collections.ObjectModel.Collection`1<JobRadar.JobRadarBaza.Models.Konkurs>
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_9_Collection;
                userType.CollectionAdd = VectorAdd_9_Collection;
                xamlType = userType;
                break;

            case 10:   //  JobRadar.JobRadarBaza.Models.Konkurs
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.AddMemberName("LokacijaId");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  Int32
                xamlType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 12:   //  JobRadar.LogInForma
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_LogInForma;
                userType.AddMemberName("LoginKorisnik");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  System.Windows.Input.ICommand
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, null);
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 14:   //  JobRadar.Pocetna
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_Pocetna;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  JobRadar.PocetnaRegistracija
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_15_PocetnaRegistracija;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 16:   //  JobRadar.PregledKonkursa
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_16_PregledKonkursa;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 17:   //  JobRadar.ProfilPoslodavca
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_17_ProfilPoslodavca;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 18:   //  JobRadar.Registracija2Forma
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_18_Registracija2Forma;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 19:   //  JobRadar.RegistracijaForma
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_19_RegistracijaForma;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 20:   //  JobRadar.ProfilNezaposlenog
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_20_ProfilNezaposlenog;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 21:   //  JobRadar.Registracija3Forma
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_21_Registracija3Forma;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 22:   //  JobRadar.RegistracijaPoslodavca
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_22_RegistracijaPoslodavca;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 23:   //  JobRadar.UnosKonkursa
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_23_UnosKonkursa;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 24:   //  JobRadar.MainPage
                userType = new global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_24_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_Color_A(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.A;
        }
        private void set_0_Color_A(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.A = (global::System.Byte)Value;
        }
        private object get_1_Color_B(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.B;
        }
        private void set_1_Color_B(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.B = (global::System.Byte)Value;
        }
        private object get_2_Color_G(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.G;
        }
        private void set_2_Color_G(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.G = (global::System.Byte)Value;
        }
        private object get_3_Color_R(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.R;
        }
        private void set_3_Color_R(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.R = (global::System.Byte)Value;
        }
        private object get_4_HomePage_Konkursi(object instance)
        {
            var that = (global::JobRadar.HomePage)instance;
            return that.Konkursi;
        }
        private void set_4_HomePage_Konkursi(object instance, object Value)
        {
            var that = (global::JobRadar.HomePage)instance;
            that.Konkursi = (global::System.Collections.ObjectModel.ObservableCollection<global::JobRadar.JobRadarBaza.Models.Konkurs>)Value;
        }
        private object get_5_Konkurs_LokacijaId(object instance)
        {
            var that = (global::JobRadar.JobRadarBaza.Models.Konkurs)instance;
            return that.LokacijaId;
        }
        private void set_5_Konkurs_LokacijaId(object instance, object Value)
        {
            var that = (global::JobRadar.JobRadarBaza.Models.Konkurs)instance;
            that.LokacijaId = (global::System.Int32)Value;
        }
        private object get_6_LogInForma_LoginKorisnik(object instance)
        {
            var that = (global::JobRadar.LogInForma)instance;
            return that.LoginKorisnik;
        }
        private void set_6_LogInForma_LoginKorisnik(object instance, object Value)
        {
            var that = (global::JobRadar.LogInForma)instance;
            that.LoginKorisnik = (global::System.Windows.Input.ICommand)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::JobRadar.JobRadar_XamlTypeInfo.XamlMember xamlMember = null;
            global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Windows.UI.Color.A":
                userType = (global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::JobRadar.JobRadar_XamlTypeInfo.XamlMember(this, "A", "Byte");
                xamlMember.Getter = get_0_Color_A;
                xamlMember.Setter = set_0_Color_A;
                break;
            case "Windows.UI.Color.B":
                userType = (global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::JobRadar.JobRadar_XamlTypeInfo.XamlMember(this, "B", "Byte");
                xamlMember.Getter = get_1_Color_B;
                xamlMember.Setter = set_1_Color_B;
                break;
            case "Windows.UI.Color.G":
                userType = (global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::JobRadar.JobRadar_XamlTypeInfo.XamlMember(this, "G", "Byte");
                xamlMember.Getter = get_2_Color_G;
                xamlMember.Setter = set_2_Color_G;
                break;
            case "Windows.UI.Color.R":
                userType = (global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::JobRadar.JobRadar_XamlTypeInfo.XamlMember(this, "R", "Byte");
                xamlMember.Getter = get_3_Color_R;
                xamlMember.Setter = set_3_Color_R;
                break;
            case "JobRadar.HomePage.Konkursi":
                userType = (global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType)GetXamlTypeByName("JobRadar.HomePage");
                xamlMember = new global::JobRadar.JobRadar_XamlTypeInfo.XamlMember(this, "Konkursi", "System.Collections.ObjectModel.ObservableCollection`1<JobRadar.JobRadarBaza.Models.Konkurs>");
                xamlMember.Getter = get_4_HomePage_Konkursi;
                xamlMember.Setter = set_4_HomePage_Konkursi;
                break;
            case "JobRadar.JobRadarBaza.Models.Konkurs.LokacijaId":
                userType = (global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType)GetXamlTypeByName("JobRadar.JobRadarBaza.Models.Konkurs");
                xamlMember = new global::JobRadar.JobRadar_XamlTypeInfo.XamlMember(this, "LokacijaId", "Int32");
                xamlMember.Getter = get_5_Konkurs_LokacijaId;
                xamlMember.Setter = set_5_Konkurs_LokacijaId;
                break;
            case "JobRadar.LogInForma.LoginKorisnik":
                userType = (global::JobRadar.JobRadar_XamlTypeInfo.XamlUserType)GetXamlTypeByName("JobRadar.LogInForma");
                xamlMember = new global::JobRadar.JobRadar_XamlTypeInfo.XamlMember(this, "LoginKorisnik", "System.Windows.Input.ICommand");
                xamlMember.Getter = get_6_LogInForma_LoginKorisnik;
                xamlMember.Setter = set_6_LogInForma_LoginKorisnik;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::JobRadar.JobRadar_XamlTypeInfo.XamlSystemBaseType
    {
        global::JobRadar.JobRadar_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::JobRadar.JobRadar_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::JobRadar.JobRadar_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::JobRadar.JobRadar_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

