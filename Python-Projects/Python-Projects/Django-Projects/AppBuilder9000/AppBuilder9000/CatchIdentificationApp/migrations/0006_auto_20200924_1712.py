# Generated by Django 2.2.5 on 2020-09-25 00:12

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('CatchIdentificationApp', '0005_auto_20200924_1617'),
    ]

    operations = [
        migrations.RenameField(
            model_name='thebigone',
            old_name='user_Name',
            new_name='fishing_Name',
        ),
        migrations.RenameField(
            model_name='thecontact',
            old_name='user_Name',
            new_name='fishing_Name',
        ),
    ]