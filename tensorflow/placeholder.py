import tensorflow as tf

x = tf.constant(1,name = "x")
#プレースホルダーという箱を作る
#tf.int32というデータの型のみ明示

y = tf.placeholder(tf.int32,name = "y")

add_op = tf.add(x,y)

with tf.Session() as sess:
    sess.run(tf.global_variables_initializer())
    print(sess.run(add_op,feed_dict={y:1}))
    print(sess.run(add_op,feed_dict={y:3}))
