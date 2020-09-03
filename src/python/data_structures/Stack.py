import random
from typing import Optional

from data_structures.LinkedList import LinkedList
from data_structures.Node import Node


# First in, last out
class Stack(LinkedList):
    def push_random_number(self):
        num = random.randint(1, 100)
        print(f"Push {num}")
        self.push(num)

    def push(self, num: int):
        node = Node(num)
        node.parent = self._tail
        self.addNode(node)

    def pop(self) -> Optional[int]:
        tail = self._tail
        if not tail:
            self._tail = None
            return None
        self._tail = tail.parent
        return tail.val
