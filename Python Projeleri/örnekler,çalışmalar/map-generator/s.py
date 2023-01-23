import pygame
import random

# Genişlik ve uzunluk değişkenlerini ayarlayın
width = 1200
height = 1000

# Oyun penceresini oluşturun ve ayarlayın
pygame.init()
screen = pygame.display.set_mode((width, height))

# Ağaç ve taş resimlerini yükleyin
yol = __file__.split("s.py")
yol = yol[0]
tree_image = pygame.image.load(yol+"tree.png")
rock_image = pygame.image.load(yol+"rock.png")

# Haritanın üzerine ağaçlar ve taşlar ekleyin
for i in range(50):
    x = random.randint(0, width)
    y = random.randint(0, height)
    screen.blit(tree_image, (x, y))

for i in range(20):
    x = random.randint(0, width)
    y = random.randint(0, height)
    screen.blit(rock_image, (x, y))

# Oyun penceresini güncelleyin ve gösterin
pygame.display.flip()
pygame.display.update()

# Oyun penceresini bekletin
input("Press enter to quit")

# Pygame'i kapatın
pygame.quit()
