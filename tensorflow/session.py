import tensorflow as tf

cnt = tf.Variable(0,name = "cnt")
inc = tf.constant(1,name = "inc")

add_op = tf.add(cnt,inc)
up_op = tf.assign(cnt,add_op)

with tf.Session() as sess:
    sess.run(tf.global_variables_initializer())
    print(sess.run(up_op))
    print(sess.run(up_op))
    print(sess.run(up_op))
#sessionが違うと変数の情報は引き継がれない
with tf.Session() as sess:
    sess.run(tf.global_variables_initializer())
    print(sess.run(up_op))
    print(sess.run(up_op))
    print(sess.run(up_op))
