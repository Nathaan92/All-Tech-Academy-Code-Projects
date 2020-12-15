from django.db import models


class djangoClasses(models.Model):
    Title = models.CharField(max_length=60, default="")
    Course_Number = models.CharField(max_length=300, default="")
    Instructor_Name = models.CharField(max_length=60, default="")
    Duration = models.DecimalField(default=0.00, max_digits=1000, decimal_places=2)

    objects = models.Manager()

    def __str__(self):
        return self.Title

# Create your models here.
