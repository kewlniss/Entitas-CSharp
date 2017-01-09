//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {

    public partial class Entity {

        static readonly AnimatingComponent animatingComponent = new AnimatingComponent();

        public bool isAnimating {
            get { return HasComponent(ComponentIds.Animating); }
            set {
                if(value != isAnimating) {
                    if(value) {
                        AddComponent(ComponentIds.Animating, animatingComponent);
                    } else {
                        RemoveComponent(ComponentIds.Animating);
                    }
                }
            }
        }

        public Entity IsAnimating(bool value) {
            isAnimating = value;
            return this;
        }
    }

    public partial class Context {

        public Entity animatingEntity { get { return GetGroup(Matcher.Animating).GetSingleEntity(); } }

        public bool isAnimating {
            get { return animatingEntity != null; }
            set {
                var entity = animatingEntity;
                if(value != (entity != null)) {
                    if(value) {
                        CreateEntity().isAnimating = true;
                    } else {
                        DestroyEntity(entity);
                    }
                }
            }
        }
    }

    public partial class Matcher {

        static IMatcher _matcherAnimating;

        public static IMatcher Animating {
            get {
                if(_matcherAnimating == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Animating);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherAnimating = matcher;
                }

                return _matcherAnimating;
            }
        }
    }
}
