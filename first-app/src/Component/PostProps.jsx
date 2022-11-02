import React from 'react'

const PostProps = (props) => {
    const {post} = props;
    const {userId, id, title, body} = post;
    // console.log(userId);
  return (
    <>
     {post.map((data)=>{
        return(
            <div>
                <ul>
                    <li>{data.userId}</li>
                    <li>{data.id}</li>
                    <li>{data.title}</li>
                    <li>{data.body}</li>
                </ul>
            </div>
        )
     })}
    </>
  )
}

export default PostProps
