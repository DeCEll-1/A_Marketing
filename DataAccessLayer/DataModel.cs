using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStrTest);
            cmd = con.CreateCommand();
        }

        #region Validasyonlar

        public bool IsANumber(string number)
        {
            bool a = true;
            if (number == "")
            {
                a = false;
                return a;
            }
            foreach (char item in number)
            {
                if (!(item >=48 && item <=57))
                {
                    a = false;
                }
            }
            return a;
        }

        #endregion

        #region Kullanıcı Metotları

        public KullaniciLoginModel KullaniciGiris(string kullaniciAdi, string sifre)
        {
            try
            {
                KullaniciLoginModel k = new KullaniciLoginModel();
                cmd.CommandText = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi=@id AND Sifre=@sifre AND Silinmis=0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                con.Open();
                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi != 0)
                {
                    cmd.CommandText = "SELECT ID,Isim,Soyisim,KullaniciAdi,Durum FROM Kullanicilar WHERE KullaniciAdi=@id AND Sifre=@sifre AND Silinmis=0";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        k.ID = reader.GetInt32(0);
                        k.Isim = reader.GetString(1);
                        k.Soyisim = reader.GetString(2);
                        k.KullaniciAdi = reader.GetString(3);
                        k.Durum = reader.GetBoolean(4);
                    }
                }
                return k;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Tedarikçi Metotları

        public List<Tedarikci> TedarikciListeleReader()
        {
            List<Tedarikci> tedarikciler = new List<Tedarikci>();
            try
            {
                cmd.CommandText = "SELECT T.ID, T.FirmaAdi, T.Yetkili, T.FirmaTelefon, T.Email, T.Sehir_ID, S.Isim, T.Ilce_ID, I.Isim, T.Adres, T.Durum FROM Tedarikciler AS T JOIN Sehirler AS S ON T.Sehir_ID = S.ID JOIN Ilceler AS I ON T.Ilce_ID = I.ID WHERE T.Silinmis = 0";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tedarikciler.Add(new Tedarikci()
                    {
                        ID = reader.GetInt32(0),
                        FirmaAdi = reader.GetString(1),
                        Yetkili = reader.GetString(2),
                        FirmaTelefon = reader.GetString(3),
                        Email = reader.GetString(4),
                        Sehir_ID = reader.GetInt32(5),
                        Sehir = reader.GetString(6),
                        Ilce_ID = reader.GetInt32(7),
                        Ilce = reader.GetString(8),
                        Adres = reader.GetString(9),
                        Durum = reader.GetBoolean(10)
                    });

                }
                return tedarikciler;

            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool TedarikciEkle(Tedarikci model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Tedarikciler(FirmaAdi, Yetkili, FirmaTelefon, Email, Sehir_ID, Ilce_ID, Adres, Durum, Silinmis) VALUES(@firmaAdi, @yetkili, @firmaTelefon, @email, @sehir_ID, @ilce_ID, @adres, @durum, 0)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@firmaAdi", model.FirmaAdi);
                cmd.Parameters.AddWithValue("@yetkili", model.Yetkili);
                cmd.Parameters.AddWithValue("@firmaTelefon", model.FirmaTelefon);
                cmd.Parameters.AddWithValue("@email", model.Email);
                cmd.Parameters.AddWithValue("@sehir_ID", model.Sehir_ID);
                cmd.Parameters.AddWithValue("@ilce_ID", model.Ilce_ID);
                cmd.Parameters.AddWithValue("@adres", model.Adres);
                cmd.Parameters.AddWithValue("@durum", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Tedarikci TedarikciGetir(int id)
        {
            try
            {
                Tedarikci t = new Tedarikci();
                cmd.CommandText = "SELECT T.ID, T.FirmaAdi, T.Yetkili, T.FirmaTelefon, T.Email, T.Sehir_ID, S.Isim, T.Ilce_ID, I.Isim, T.Adres, T.Durum FROM Tedarikciler AS T JOIN Sehirler AS S ON T.Sehir_ID = S.ID JOIN Ilceler AS I ON T.Ilce_ID = I.ID WHERE T.ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    t = new Tedarikci()
                    {
                        ID = reader.GetInt32(0),
                        FirmaAdi = reader.GetString(1),
                        Yetkili = reader.GetString(2),
                        FirmaTelefon = reader.GetString(3),
                        Email = reader.GetString(4),
                        Sehir_ID = reader.GetInt32(5),
                        Sehir = reader.GetString(6),
                        Ilce_ID = reader.GetInt32(7),
                        Ilce = reader.GetString(8),
                        Adres = reader.GetString(9),
                        Durum = reader.GetBoolean(10)
                    };
                }
                return t;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool TedarikciGuncelle(Tedarikci model)
        {
            try
            {
                cmd.CommandText = "UPDATE Tedarikciler SET FirmaAdi=@firmaadi, Yetkili =@yetkili, FirmaTelefon = @firmatelefon, Email=@email, Sehir_ID=@sehir_ID, Ilce_ID=@ilce_ID, Adres=@adres, Durum=@durum WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.ID);
                cmd.Parameters.AddWithValue("@firmaadi", model.FirmaAdi);
                cmd.Parameters.AddWithValue("@yetkili", model.Yetkili);
                cmd.Parameters.AddWithValue("@firmatelefon", model.FirmaTelefon);
                cmd.Parameters.AddWithValue("@email", model.Email);
                cmd.Parameters.AddWithValue("@sehir_ID", model.Sehir_ID);
                cmd.Parameters.AddWithValue("@ilce_ID", model.Ilce_ID);
                cmd.Parameters.AddWithValue("@adres", model.Adres);
                cmd.Parameters.AddWithValue("@durum", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool TedarikciSil(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE Tedarikciler SET Silinmis=1 WHERE ID= @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Şehir İlçe Metotları

        public List<Sehir> SehirleriListele()
        {
            List<Sehir> Sehirler = new List<Sehir>();
            try
            {
                cmd.CommandText = "SELECT * FROM Sehirler";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sehirler.Add(new Sehir()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(1)
                    });
                }
                return Sehirler;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Ilce> IlceleriListele(int sehirID)
        {
            List<Ilce> ilceler = new List<Ilce>();
            try
            {
                cmd.CommandText = "SELECT * FROM Ilceler WHERE SehirID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", sehirID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ilceler.Add(new Ilce()
                    {
                        ID = reader.GetInt32(0),
                        Sehir_ID = reader.GetInt32(1),
                        Isim = reader.GetString(2)
                    });
                }
                return ilceler;
            }
            finally
            {
                con.Close();
            }
        }


        #endregion

        #region Kategori Metotları

        public bool KategoriEkle(Kategori kat, bool UstKatVarmi)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Kategoriler(UstKategori_ID,Isim,Durum,Silinmis) VALUES(@UstKategori_ID,@Isim, @Durum, @Silinmis)";
                cmd.Parameters.Clear();
                if (UstKatVarmi)    
                {
                    cmd.Parameters.AddWithValue("@UstKategori_ID", kat.UstKategori_ID);
                }
                cmd.Parameters.AddWithValue("@Isim", kat.Isim);
                cmd.Parameters.AddWithValue("@Durum", kat.Durum);
                cmd.Parameters.AddWithValue("@Silinmis", kat.Silinmis);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally { con.Close(); }

        }

        public bool AdIleGetKategori()
        {
            try
            {


                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public List<Kategori> AltındaKategoriOlanUstKategorileriGetir(int silinmis)
        {
            try
            {
                List<Kategori> kat = new List<Kategori>();
                cmd.CommandText = "EXEC usp_AltındaKategoriOlanUstKategorileriGetir @Silinmis";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Silinmis", silinmis);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(1))
                    {
                        kat.Add(new Kategori()
                        {
                            ID = reader.GetInt32(0),
                            UstKategoriIsim = reader.GetString(2),
                            Isim = reader.GetString(3),
                            Durum = reader.GetBoolean(4),
                            Silinmis = reader.GetBoolean(5),
                        }
                        );
                    }
                    else
                    {
                        kat.Add(new Kategori()
                        {
                            ID = reader.GetInt32(0),
                            UstKategori_ID = reader.GetInt32(1),
                            UstKategoriIsim = reader.GetString(2),
                            Isim = reader.GetString(3),
                            Durum = reader.GetBoolean(4),
                            Silinmis = reader.GetBoolean(5),
                        });
                    }
                    
                }
                return kat;
            }
            catch (Exception) { return null; }
            finally { con.Close(); }
        }

        public List<Kategori> AltKategorisiVeUstKategorisiOlanlariListele(int silinmis)
        {
            try
            {
                List<Kategori> kat = new List<Kategori>();
                cmd.CommandText = "EXEC usp_AltKategorisiVeUstKategorisiOlanlariListele @Silinmis";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Silinmis", silinmis);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    kat.Add(new Kategori()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(1),
                        UstKategoriIsim = reader.GetString(2),
                        AltKategoriIsim = reader.GetString(3),
                        UstKategori_ID = reader.GetInt32(4),
                        Durum = reader.GetBoolean(5),
                        Silinmis = reader.GetBoolean(6),
                    });
                }

                return kat;
            }
            catch (Exception) { return null; }
            finally { con.Close(); }
        }

        public List<Kategori> UstKategoriyeGoreListele(int ustkategoriid, int silinmis)
        {
            try
            {
                List<Kategori> kat = new List<Kategori>();
                cmd.CommandText = "EXEC usp_UstKategoriyeGoreListele @Silinmis,@UstKategori_ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@UstKategori_ID", ustkategoriid);
                cmd.Parameters.AddWithValue("@Silinmis", silinmis);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    kat.Add(new Kategori()
                    {
                        ID = reader.GetInt32(0),
                        UstKategori_ID = reader.GetInt32(1),
                        UstKategoriIsim = reader.GetString(2),
                        Isim = reader.GetString(3),
                        Durum = reader.GetBoolean(4),
                        Silinmis = reader.GetBoolean(5),
                    });
                }
                return kat;
            }
            catch (Exception)
            {
                return null;
            }
            finally { con.Close(); }
        }

        public List<Kategori> EnUstKategorileriListele(int silinmis)
        {
            try
            {
                List<Kategori> kat = new List<Kategori>();

                cmd.CommandText = "EXEC usp_EnUstKategorileriListele @Silinmis";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Silinmis", silinmis);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    kat.Add(new Kategori()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(2),
                        Durum = reader.GetBoolean(3),
                        Silinmis = reader.GetBoolean(4),
                    });
                }
                return kat;
            }
            catch (Exception)
            {
                return null;
            }
            finally { con.Close(); }
        }

        public List<Kategori> ButunKategorileriListele(int silinmis)
        {
            List<Kategori> kategoriler = new List<Kategori>();
            try
            {
                cmd.CommandText = "EXEC usp_ButunKategorileriListele @Silinmis";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Silinmis", silinmis);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(1))
                    {
                        kategoriler.Add(new Kategori()
                        {

                            ID = reader.GetInt32(0),
                            Isim = reader.GetString(2),
                            Durum = reader.GetBoolean(3),
                            Silinmis = reader.GetBoolean(4),
                        }
                        );
                    }
                    else
                    {
                        kategoriler.Add(new Kategori()
                        {

                            ID = reader.GetInt32(0),
                            UstKategori_ID = reader.GetInt32(1),
                            Isim = reader.GetString(2),
                            Durum = reader.GetBoolean(3),
                            Silinmis = reader.GetBoolean(4),
                        }
                        );
                    }
                }
                return kategoriler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Marka Metotları

        public List<Marka> MarkaListele()
        {
            List<Marka> markalar = new List<Marka>();
            try
            {
                cmd.CommandText = "SELECT ID, Isim FROM Markalar WHERE Silinmis=0";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    markalar.Add(new Marka()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(1)
                    });
                }
                return markalar;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool MarkaEkle(Marka marka)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Markalar(Isim,Durum,Silinmis) VALUES(@Isim, @Durum, @Silinmis)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Isim", marka.Isim);
                cmd.Parameters.AddWithValue("@Durum", marka.Durum);
                cmd.Parameters.AddWithValue("@Silinmis", marka.Silinmis);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally { con.Close(); }
        }
        #endregion

        #region Birim Metotları

        public bool BirimEkle(Birim birim)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Birimler(Isim,Durum,Silinmis) VALUES(@Isim,@Durum,@Silinmis)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Isim", birim.Isim);
                cmd.Parameters.AddWithValue("@Durum", birim.Durum);
                cmd.Parameters.AddWithValue("@Silinmis", birim.Silinmis);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally { con.Close(); }
        }

        public List<Birim> BirimListele()
        {
            List<Birim> markalar = new List<Birim>();
            try
            {
                cmd.CommandText = "SELECT ID, Isim FROM Birimler WHERE Silinmis=0";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    markalar.Add(new Birim()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(1)
                    });
                }
                return markalar;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Ürün Metotları

        public Urun GetUrun(int ID)
        {
            try
            {
                Urun u = new Urun();
                cmd.CommandText = "SELECT * FROM Urunler WHERE ID = @ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", ID);
                con.Open();
                cmd.ExecuteNonQuery();
                return u;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UrunEkle(Urun model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Urunler(BarkodNo, Kategori_ID, Marka_ID, Birim_ID, KDVOrani, Isim, Stok, Aciklama, BirimFiyat, Durum, Silinmis) VALUES(@BarkodNo, @Kategori_ID, @Marka_ID, @Birim_ID, @KDVOrani, @Isim, @Stok, @Aciklama, @BirimFiyat, @Durum, @Silinmis)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@BarkodNo", model.BarkodNo);
                cmd.Parameters.AddWithValue("@Kategori_ID", model.Kategori_ID);
                cmd.Parameters.AddWithValue("@Marka_ID", model.Marka_ID);
                cmd.Parameters.AddWithValue("@Birim_ID", model.Birim_ID);
                cmd.Parameters.AddWithValue("@KDVOrani", model.KDVOrani);
                cmd.Parameters.AddWithValue("@Isim", model.Isim);
                cmd.Parameters.AddWithValue("@Stok", model.Stok);
                cmd.Parameters.AddWithValue("@Aciklama", model.Aciklama);
                cmd.Parameters.AddWithValue("@BirimFiyat", model.BirimFiyat);
                cmd.Parameters.AddWithValue("@Durum", model.Durum);
                cmd.Parameters.AddWithValue("@Silinmis", model.Silinmis);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable UrunListele()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd.CommandText = "SELECT * FROM UrunListele";
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                adptr.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion
    }
}
