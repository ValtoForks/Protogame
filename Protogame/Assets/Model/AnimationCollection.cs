﻿namespace Protogame
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An implementation of <see cref="IAnimationCollection"/>.
    /// </summary>
    public class AnimationCollection : IAnimationCollection
    {
        /// <summary>
        /// The dictionary that maps animation names to animations.
        /// </summary>
        private readonly Dictionary<string, IAnimation> m_Dictionary;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationCollection"/> class.
        /// </summary>
        /// <param name="animations">
        /// The animations.
        /// </param>
        public AnimationCollection(IEnumerable<IAnimation> animations)
        {
            this.m_Dictionary = animations.ToDictionary(key => key.Name, value => value);
        }

        /// <summary>
        /// Retrieve an animation by the animation's name.
        /// </summary>
        /// <param name="name">
        /// The name of the animation.
        /// </param>
        /// <returns>
        /// The <see cref="IAnimation"/>.
        /// </returns>
        /// <exception cref="KeyNotFoundException">
        /// Thrown if there is no such animation.
        /// </exception>
        public IAnimation this[string name]
        {
            get
            {
                if (!this.m_Dictionary.ContainsKey(name))
                {
                    throw new KeyNotFoundException(name + " is not an animation");
                }

                return this.m_Dictionary[name];
            }
        }

        /// <summary>
        /// Retrieves the enumerator for enumerating over the collection of animations.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerator"/> for enumerating over the collection of animations.
        /// </returns>
        public IEnumerator<IAnimation> GetEnumerator()
        {
            return this.m_Dictionary.Values.GetEnumerator();
        }

        /// <summary>
        /// Retrieves the enumerator for enumerating over the collection of animations.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerator"/> for enumerating over the collection of animations.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.m_Dictionary.Values.GetEnumerator();
        }
    }
}