import React from 'react'

const Post = (props) => {
    const {post} = props;
  return (
    <>
      {post.map((post)=>{
        return(
            <ul>
               <li> {post.userId}</li>
               <li> {post.id}</li>
               <li> {post.title}</li>
               <li> {post.body}</li>
            </ul>
        )
      })}
    </>
  )
}

export default Post
