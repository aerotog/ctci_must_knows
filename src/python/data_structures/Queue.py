from typing import Optional

from data_structures.LinkedList import LinkedList


# First in, first out
class Queue(LinkedList):
    def Enqueue(self, num: int):
        self.add(num)

    def Dequeue(self) -> Optional[int]:
        if self._head:
            front = self._head
            self._head = self._head.next
            return front.val
        else:
            return None
