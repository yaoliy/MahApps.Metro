using System.ComponentModel;
using System.Runtime.CompilerServices;
using MetroDemo2.Annotations;

namespace MetroDemo2
{
    public class DataModel : INotifyPropertyChanged
    {
        int _item1, _item2, _item3, _item4, _item5, _item6, _item7, _item8, _item9, _item10;
        int _item11, _item12, _item13, _item14, _item15, _item16, _item17, _item18, _item19, _item20;
        int _item21, _item22, _item23, _item24, _item25, _item26, _item27, _item28, _item29, _item30;
        int _item31, _item32, _item33, _item34, _item35, _item36, _item37, _item38, _item39, _item40;
        int _item41, _item42, _item43, _item44, _item45, _item46, _item47, _item48, _item49, _item50;
        
        public void SetData(int start)
        {
            Item1 = start;
            Item2 = Item1 + 1;
            Item3 = Item2 + 1;
            Item4 = Item3 + 1;
            Item5 = Item4 + 1;
            Item6 = Item5 + 1;
            Item7 = Item6 + 1;
            Item8 = Item7 + 1;
            Item9 = Item8 + 1;
            Item10 = Item9 + 1;

            Item11 = Item10 + 1;
            Item12 = Item11 + 1;
            Item13 = Item12 + 1;
            Item14 = Item13 + 1;
            Item15 = Item14 + 1;
            Item16 = Item15 + 1;
            Item17 = Item16 + 1;
            Item18 = Item17 + 1;
            Item19 = Item18 + 1;
            Item20 = Item19 + 1;

            Item21 = Item20 + 1;
            Item22 = Item21 + 1;
            Item23 = Item22 + 1;
            Item24 = Item23 + 1;
            Item25 = Item24 + 1;
            Item26 = Item25 + 1;
            Item27 = Item26 + 1;
            Item28 = Item27 + 1;
            Item29 = Item28 + 1;
            Item30 = Item29 + 1;

            Item31 = Item30 + 1;
            Item32 = Item31 + 1;
            Item33 = Item32 + 1;
            Item34 = Item33 + 1;
            Item35 = Item34 + 1;
            Item36 = Item35 + 1;
            Item37 = Item36 + 1;
            Item38 = Item37 + 1;
            Item39 = Item38 + 1;
            Item40 = Item39 + 1;

            Item41 = Item40 + 1;
            Item42 = Item41 + 1;
            Item43 = Item42 + 1;
            Item44 = Item43 + 1;
            Item45 = Item44 + 1;
            Item46 = Item45 + 1;
            Item47 = Item46 + 1;
            Item48 = Item47 + 1;
            Item49 = Item48 + 1;
            Item50 = Item49 + 1;
        }

        public int Item1 {
            get { return _item1; }
            set { _item1 = value; OnPropertyChanged(); }
        }
        
        public int Item2 {
            get { return _item2; }
            set { _item2 = value; OnPropertyChanged(); }
        }

        public int Item3 {
            get { return _item3; }
            set { _item3 = value; OnPropertyChanged(); }
        }

        public int Item4 {
            get { return _item4; }
            set { _item4 = value; OnPropertyChanged(); }
        }

        public int Item5 {
            get { return _item5; }
            set { _item5 = value; OnPropertyChanged(); }
        }

        public int Item6 {
            get { return _item6; }
            set { _item6 = value; OnPropertyChanged(); }
        }

        public int Item7 {
            get { return _item7; }
            set { _item7 = value; OnPropertyChanged(); }
        }
        
        public int Item8 {
            get { return _item8; }
            set { _item8 = value; OnPropertyChanged(); }
        }

        public int Item9 {
            get { return _item9; }
            set { _item9 = value; OnPropertyChanged(); }
        }

        public int Item10 {
            get { return _item10; }
            set { _item10 = value; OnPropertyChanged(); }
        }

        public int Item11 {
            get { return _item11; }
            set { _item11 = value; OnPropertyChanged(); }
        }

        public int Item12 {
            get { return _item12; }
            set { _item12 = value; OnPropertyChanged(); }
        }

        public int Item13 {
            get { return _item13; }
            set { _item13 = value; OnPropertyChanged(); }
        }

        public int Item14 {
            get { return _item14; }
            set { _item14 = value; OnPropertyChanged(); }
        }

        public int Item15 {
            get { return _item15; }
            set { _item15 = value; OnPropertyChanged(); }
        }

        public int Item16 {
            get { return _item16; }
            set { _item16 = value; OnPropertyChanged(); }
        }

        public int Item17 {
            get { return _item17; }
            set { _item17 = value; OnPropertyChanged(); }
        }

        public int Item18 {
            get { return _item18; }
            set { _item18 = value; OnPropertyChanged(); }
        }

        public int Item19 {
            get { return _item19; }
            set { _item19 = value; OnPropertyChanged(); }
        }

        public int Item20 {
            get { return _item20; }
            set { _item20 = value; OnPropertyChanged(); }
        }

        public int Item21 {
            get { return _item21; }
            set { _item21 = value; OnPropertyChanged(); }
        }

        public int Item22 {
            get { return _item22; }
            set { _item22 = value; OnPropertyChanged(); }
        }

        public int Item23 {
            get { return _item23; }
            set { _item23 = value; OnPropertyChanged(); }
        }

        public int Item24 {
            get { return _item24; }
            set { _item24 = value; OnPropertyChanged(); }
        }

        public int Item25 {
            get { return _item25; }
            set { _item25 = value; OnPropertyChanged(); }
        }

        public int Item26 {
            get { return _item26; }
            set { _item26 = value; OnPropertyChanged(); }
        }

        public int Item27 {
            get { return _item27; }
            set { _item27 = value; OnPropertyChanged(); }
        }

        public int Item28 {
            get { return _item28; }
            set { _item28 = value; OnPropertyChanged(); }
        }

        public int Item29 {
            get { return _item29; }
            set { _item29 = value; OnPropertyChanged(); }
        }

        public int Item30 {
            get { return _item30; }
            set { _item30 = value; OnPropertyChanged(); }
        }

        public int Item31 {
            get { return _item31; }
            set { _item31 = value; OnPropertyChanged(); }
        }

        public int Item32 {
            get { return _item32; }
            set { _item32 = value; OnPropertyChanged(); }
        }

        public int Item33 {
            get { return _item33; }
            set { _item33 = value; OnPropertyChanged(); }
        }

        public int Item34 {
            get { return _item34; }
            set { _item34 = value; OnPropertyChanged(); }
        }

        public int Item35 {
            get { return _item35; }
            set { _item35 = value; OnPropertyChanged(); }
        }

        public int Item36 { 
            get { return _item36; }
            set { _item36 = value; OnPropertyChanged(); }
        }

        public int Item37 {
            get { return _item37; }
            set { _item37 = value; OnPropertyChanged(); }
        }

        public int Item38 {
            get { return _item38; }
            set { _item38 = value; OnPropertyChanged(); }
        }

        public int Item39 {
            get { return _item39; }
            set { _item39 = value; OnPropertyChanged(); }
        }

        public int Item40 {
            get { return _item40; }
            set { _item40 = value; OnPropertyChanged(); }
        }

        public int Item41 {
            get { return _item41; }
            set { _item41 = value; OnPropertyChanged(); }
        }

        public int Item42 {
            get { return _item42; }
            set { _item42 = value; OnPropertyChanged(); }
        }

        public int Item43 {
            get { return _item43; }
            set { _item43 = value; OnPropertyChanged(); }
        }

        public int Item44 { 
            get { return _item44; }
            set { _item44 = value; OnPropertyChanged(); }
        }

        public int Item45 {
            get { return _item45; }
            set { _item45 = value; OnPropertyChanged(); }
        }

        public int Item46 {
            get { return _item46; }
            set { _item46 = value; OnPropertyChanged(); }
        }

        public int Item47 {
            get { return _item47; }
            set { _item47 = value; OnPropertyChanged(); }
        }

        public int Item48 {
            get { return _item48; }
            set { _item48 = value; OnPropertyChanged(); }
        }

        public int Item49 {
            get { return _item49; }
            set { _item49 = value; OnPropertyChanged(); }
        }

        public int Item50 {
            get { return _item50; }
            set { _item50 = value; OnPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}