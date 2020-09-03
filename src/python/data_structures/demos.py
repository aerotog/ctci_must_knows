from random import randint

from data_structures.LinkedList import LinkedList
from data_structures.Queue import Queue
from data_structures.Stack import Stack


def run_linked_list_demo():
    print("\nRandomly generated linked list:")
    l_list = LinkedList()
    for i in range(10):
        num = randint(1, 100)
        print(f"Add {num}")
        l_list.add(num)


def run_stack_demo():
    print("\nRandomly generated stack")
    stack = Stack()
    for i in range(10):
        stack.push_random_number()

    popped = 1
    while popped:
        popped = stack.pop()
        print(f"Popped {popped}")


def run_queue_demo():
    print("\nRandomly generated queue")
    queue = Queue()
    for i in range(10):
        num = randint(1, 100)
        print(f"Enqueue {num}")
        queue.Enqueue(num)

    deq = 1
    while deq:
        deq = queue.Dequeue()
        print(f"Dequeued {deq}")


def run():
    run_linked_list_demo()
    run_stack_demo()
    run_queue_demo()
