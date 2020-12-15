# Generated by Django 2.2.5 on 2020-09-04 21:45

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('SendItApp', '0010_auto_20200904_1332'),
    ]

    operations = [
        migrations.CreateModel(
            name='Boulder',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(default='', max_length=40)),
                ('grade', models.CharField(default=0.0, max_length=20)),
                ('rock', models.CharField(choices=[('Quartzite', 'Quartzite'), ('Unknown', 'Unknown'), ('Limestone', 'Limestone'), ('Sandstone', 'Sandstone'), ('Granite', 'Granite')], default='Unknown', max_length=40)),
                ('status', models.CharField(choices=[('To Do', 'To Do'), ('Flash', 'Flash'), ('In Progress', 'In Progress')], default='Flash', max_length=40)),
                ('notes', models.CharField(blank=True, default='', max_length=40, null=True)),
                ('image', models.CharField(blank=True, default='', max_length=255)),
            ],
        ),
        migrations.CreateModel(
            name='Sport',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(default='', max_length=40)),
                ('grade', models.CharField(default=0.0, max_length=20)),
                ('pitches', models.DecimalField(blank=True, decimal_places=0, default='', max_digits=2, null=True)),
                ('rock', models.CharField(choices=[('Quartzite', 'Quartzite'), ('Cobble', 'Cobble'), ('Unknown', 'Unknown'), ('Limestone', 'Limestone'), ('Sandstone', 'Sandstone'), ('Granite', 'Granite')], default='Unknown', max_length=40)),
                ('status', models.CharField(choices=[('Redpoint', 'Redpoint'), ('Onsight', 'Onsight'), ('Flail', 'Flail'), ('To Do', 'To Do'), ('Flash', 'Flash'), ('Pinkpoint', 'Pinkpoint')], default='To Do', max_length=40)),
                ('image', models.CharField(blank=True, default='', max_length=255)),
            ],
        ),
        migrations.DeleteModel(
            name='Route',
        ),
    ]