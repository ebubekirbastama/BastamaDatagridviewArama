# BastamaDatagridviewArama

Bu, C# Windows Forms uygulamasıdır. Uygulama, bir DataTable kullanarak veri arama ve görüntüleme için DataGridView kullanmaktadır.

## İçindekiler
- [Genel Bakış](#genel-bakış)
- [Özellikler](#özellikler)
- [Gereksinimler](#gereksinimler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Katkıda Bulunma](#katkıda-bulunma)
- [Lisans](#lisans)

## Genel Bakış
Bu uygulama, bir DataTable içindeki verileri görüntülemek ve aramak için DataGridView kullanmanın basit bir örneğidir. 

- `Form1.cs`: Ana form dosyasıdır. DataGridView ve diğer kontroller burada tanımlanmıştır.
- `Form1_Load`: Form yüklendiğinde çağrılan metoddur. DataTable oluşturulur ve örnek veriler eklenir.
- `dataGridView1_DoubleClick`: DataGridView üzerinde çift tıklama olayını yöneten metoddur. Seçilen satırın verilerini metin kutularına doldurur.
- `textBox1_KeyPress`: TextBox'a tuş basıldığında çağrılan metoddur. TC'ye göre veriyi filtreler.
- `buttonX1_Click`: Temizleme butonuna tıklandığında çağrılan metoddur. Veriyi temizler ve tüm verileri gösterir.

## Özellikler
- Verileri bir DataGridView içinde görüntüleme.
- TC (Türkiye Kimlik Numarası) sütununa dayalı olarak veri arama ve filtreleme.
- Bir satıra çift tıklayarak metin kutularını seçilen satırın verileri ile doldurma.

## Gereksinimler
- Visual Studio (veya başka bir C# geliştirme ortamı)
- .NET Framework

## Kurulum
1. Depoyu klonlayın veya indirin.
2. Projeyi Visual Studio'da açın.
3. Uygulamayı derleyip çalıştırın.

## Kullanım
1. Uygulamayı çalıştırın.
2. Veriler DataGridView içinde görüntülenecektir.
3. Arama kutusuna bir TC girin ve Enter tuşuna basarak verileri filtreleyin.
4. Bir satıra çift tıklayarak metin kutularını seçilen satırın verileri ile doldurun.

## Katkıda Bulunma
Katkılarınızı bekliyoruz! Herhangi bir sorun bulursanız veya iyileştirme önerileriniz varsa, bir sorun açmaktan veya bir pull request oluşturmaktan çekinmeyin.

## Lisans
Bu proje [MIT License](LICENSE) altında lisanslanmıştır.
