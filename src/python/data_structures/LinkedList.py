from data_structures.Node import Node


class LinkedList:
    # noinspection PyTypeChecker
    def __init__(self):
        self._head: Node = None
        self._tail: Node = None

    def add(self, num: int) -> None:
        node = Node(num)
        self.addNode(node)

    def addNode(self, node: Node) -> None:
        if self._tail:
            self._tail.next = node
            self._tail = node
        else:
            self._head = self._tail = node
        self.print()

    def print(self):
        current = self._head
        output = ""

        while current:
            output += str(current.val) + ">"
            current = current.next

        print(output)
