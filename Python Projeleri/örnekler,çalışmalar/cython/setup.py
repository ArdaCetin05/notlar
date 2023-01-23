from setuptools import setup
from Cython.Build import cythonize

setup(name="Cython deneme",ext_modules=cythonize("main.pyx"),zip_safe=False)