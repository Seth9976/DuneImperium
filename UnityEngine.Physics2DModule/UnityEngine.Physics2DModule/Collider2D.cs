using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public class Collider2D : Behaviour
	{
		// Token: 0x060002CA RID: 714 RVA: 0x0000AC0C File Offset: 0x00008E0C
		// Note: this type is marked as 'beforefieldinit'.
		static Collider2D()
		{
			Il2CppClassPointerStore<Collider2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Collider2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collider2D>.NativeClassPtr);
			Collider2D.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663342);
			Collider2D.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663343);
			Collider2D.get_densityDelegateField = IL2CPP.ResolveICall<Collider2D.get_densityDelegate>("UnityEngine.Collider2D::get_density");
			Collider2D.set_densityDelegateField = IL2CPP.ResolveICall<Collider2D.set_densityDelegate>("UnityEngine.Collider2D::set_density");
			Collider2D.get_isTriggerDelegateField = IL2CPP.ResolveICall<Collider2D.get_isTriggerDelegate>("UnityEngine.Collider2D::get_isTrigger");
			Collider2D.set_isTriggerDelegateField = IL2CPP.ResolveICall<Collider2D.set_isTriggerDelegate>("UnityEngine.Collider2D::set_isTrigger");
			Collider2D.get_usedByEffectorDelegateField = IL2CPP.ResolveICall<Collider2D.get_usedByEffectorDelegate>("UnityEngine.Collider2D::get_usedByEffector");
			Collider2D.set_usedByEffectorDelegateField = IL2CPP.ResolveICall<Collider2D.set_usedByEffectorDelegate>("UnityEngine.Collider2D::set_usedByEffector");
			Collider2D.get_usedByCompositeDelegateField = IL2CPP.ResolveICall<Collider2D.get_usedByCompositeDelegate>("UnityEngine.Collider2D::get_usedByComposite");
			Collider2D.set_usedByCompositeDelegateField = IL2CPP.ResolveICall<Collider2D.set_usedByCompositeDelegate>("UnityEngine.Collider2D::set_usedByComposite");
			Collider2D.get_compositeDelegateField = IL2CPP.ResolveICall<Collider2D.get_compositeDelegate>("UnityEngine.Collider2D::get_composite");
			Collider2D.get_attachedRigidbodyDelegateField = IL2CPP.ResolveICall<Collider2D.get_attachedRigidbodyDelegate>("UnityEngine.Collider2D::get_attachedRigidbody");
			Collider2D.get_shapeCountDelegateField = IL2CPP.ResolveICall<Collider2D.get_shapeCountDelegate>("UnityEngine.Collider2D::get_shapeCount");
			Collider2D.CreateMeshDelegateField = IL2CPP.ResolveICall<Collider2D.CreateMeshDelegate>("UnityEngine.Collider2D::CreateMesh");
			Collider2D.GetShapeHashDelegateField = IL2CPP.ResolveICall<Collider2D.GetShapeHashDelegate>("UnityEngine.Collider2D::GetShapeHash");
			Collider2D.get_errorStateDelegateField = IL2CPP.ResolveICall<Collider2D.get_errorStateDelegate>("UnityEngine.Collider2D::get_errorState");
			Collider2D.get_compositeCapableDelegateField = IL2CPP.ResolveICall<Collider2D.get_compositeCapableDelegate>("UnityEngine.Collider2D::get_compositeCapable");
			Collider2D.get_sharedMaterialDelegateField = IL2CPP.ResolveICall<Collider2D.get_sharedMaterialDelegate>("UnityEngine.Collider2D::get_sharedMaterial");
			Collider2D.set_sharedMaterialDelegateField = IL2CPP.ResolveICall<Collider2D.set_sharedMaterialDelegate>("UnityEngine.Collider2D::set_sharedMaterial");
			Collider2D.get_layerOverridePriorityDelegateField = IL2CPP.ResolveICall<Collider2D.get_layerOverridePriorityDelegate>("UnityEngine.Collider2D::get_layerOverridePriority");
			Collider2D.set_layerOverridePriorityDelegateField = IL2CPP.ResolveICall<Collider2D.set_layerOverridePriorityDelegate>("UnityEngine.Collider2D::set_layerOverridePriority");
			Collider2D.get_frictionDelegateField = IL2CPP.ResolveICall<Collider2D.get_frictionDelegate>("UnityEngine.Collider2D::get_friction");
			Collider2D.get_bouncinessDelegateField = IL2CPP.ResolveICall<Collider2D.get_bouncinessDelegate>("UnityEngine.Collider2D::get_bounciness");
			Collider2D.IsTouchingDelegateField = IL2CPP.ResolveICall<Collider2D.IsTouchingDelegate>("UnityEngine.Collider2D::IsTouching");
			Collider2D.IsTouchingLayersDelegateField = IL2CPP.ResolveICall<Collider2D.IsTouchingLayersDelegate>("UnityEngine.Collider2D::IsTouchingLayers");
			Collider2D.get_offset_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.get_offset_InjectedDelegate>("UnityEngine.Collider2D::get_offset_Injected");
			Collider2D.set_offset_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.set_offset_InjectedDelegate>("UnityEngine.Collider2D::set_offset_Injected");
			Collider2D.get_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.get_excludeLayers_InjectedDelegate>("UnityEngine.Collider2D::get_excludeLayers_Injected");
			Collider2D.set_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.set_excludeLayers_InjectedDelegate>("UnityEngine.Collider2D::set_excludeLayers_Injected");
			Collider2D.get_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.get_includeLayers_InjectedDelegate>("UnityEngine.Collider2D::get_includeLayers_Injected");
			Collider2D.set_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.set_includeLayers_InjectedDelegate>("UnityEngine.Collider2D::set_includeLayers_Injected");
			Collider2D.get_forceSendLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.get_forceSendLayers_InjectedDelegate>("UnityEngine.Collider2D::get_forceSendLayers_Injected");
			Collider2D.set_forceSendLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.set_forceSendLayers_InjectedDelegate>("UnityEngine.Collider2D::set_forceSendLayers_Injected");
			Collider2D.get_forceReceiveLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.get_forceReceiveLayers_InjectedDelegate>("UnityEngine.Collider2D::get_forceReceiveLayers_Injected");
			Collider2D.set_forceReceiveLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.set_forceReceiveLayers_InjectedDelegate>("UnityEngine.Collider2D::set_forceReceiveLayers_Injected");
			Collider2D.get_contactCaptureLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.get_contactCaptureLayers_InjectedDelegate>("UnityEngine.Collider2D::get_contactCaptureLayers_Injected");
			Collider2D.set_contactCaptureLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.set_contactCaptureLayers_InjectedDelegate>("UnityEngine.Collider2D::set_contactCaptureLayers_Injected");
			Collider2D.get_callbackLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.get_callbackLayers_InjectedDelegate>("UnityEngine.Collider2D::get_callbackLayers_Injected");
			Collider2D.set_callbackLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.set_callbackLayers_InjectedDelegate>("UnityEngine.Collider2D::set_callbackLayers_Injected");
			Collider2D.IsTouching_OtherColliderWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.IsTouching_OtherColliderWithFilter_InjectedDelegate>("UnityEngine.Collider2D::IsTouching_OtherColliderWithFilter_Injected");
			Collider2D.IsTouching_AnyColliderWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.IsTouching_AnyColliderWithFilter_InjectedDelegate>("UnityEngine.Collider2D::IsTouching_AnyColliderWithFilter_Injected");
			Collider2D.OverlapPoint_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.OverlapPoint_InjectedDelegate>("UnityEngine.Collider2D::OverlapPoint_Injected");
			Collider2D.CastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.CastArray_Internal_InjectedDelegate>("UnityEngine.Collider2D::CastArray_Internal_Injected");
			Collider2D.CastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.CastList_Internal_InjectedDelegate>("UnityEngine.Collider2D::CastList_Internal_Injected");
			Collider2D.RaycastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.RaycastArray_Internal_InjectedDelegate>("UnityEngine.Collider2D::RaycastArray_Internal_Injected");
			Collider2D.RaycastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.RaycastList_Internal_InjectedDelegate>("UnityEngine.Collider2D::RaycastList_Internal_Injected");
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000AEF8 File Offset: 0x000090F8
		public unsafe Bounds bounds
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1268414, RefRangeEnd = 1268415, XrefRangeStart = 1268412, XrefRangeEnd = 1268414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider2D.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000AF34 File Offset: 0x00009134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268415, XrefRangeEnd = 1268417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider2D.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00003364 File Offset: 0x00001564
		public Collider2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000336D File Offset: 0x0000156D
		// (set) Token: 0x060002CF RID: 719 RVA: 0x0000337F File Offset: 0x0000157F
		public float density
		{
			get
			{
				return Collider2D.get_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider2D.set_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00003392 File Offset: 0x00001592
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x000033A4 File Offset: 0x000015A4
		public bool isTrigger
		{
			get
			{
				return Collider2D.get_isTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider2D.set_isTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000033B7 File Offset: 0x000015B7
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x000033C9 File Offset: 0x000015C9
		public bool usedByEffector
		{
			get
			{
				return Collider2D.get_usedByEffectorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider2D.set_usedByEffectorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x000033EE File Offset: 0x000015EE
		public bool usedByComposite
		{
			get
			{
				return Collider2D.get_usedByCompositeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider2D.set_usedByCompositeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000AF74 File Offset: 0x00009174
		public CompositeCollider2D composite
		{
			get
			{
				IntPtr intPtr = Collider2D.get_compositeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompositeCollider2D>(intPtr2) : null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000AFA0 File Offset: 0x000091A0
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00003401 File Offset: 0x00001601
		public Vector2 offset
		{
			get
			{
				Vector2 vector;
				this.get_offset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_offset_Injected(ref value);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000AFB8 File Offset: 0x000091B8
		public Rigidbody2D attachedRigidbody
		{
			get
			{
				IntPtr intPtr = Collider2D.get_attachedRigidbodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000340B File Offset: 0x0000160B
		public int shapeCount
		{
			get
			{
				return Collider2D.get_shapeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000AFE4 File Offset: 0x000091E4
		public Mesh CreateMesh(bool useBodyPosition, bool useBodyRotation)
		{
			IntPtr intPtr = Collider2D.CreateMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), useBodyPosition, useBodyRotation);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000341D File Offset: 0x0000161D
		public uint GetShapeHash()
		{
			return Collider2D.GetShapeHashDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000342F File Offset: 0x0000162F
		public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000343C File Offset: 0x0000163C
		public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup, int shapeIndex, [Optional] int shapeCount)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00003449 File Offset: 0x00001649
		public ColliderErrorState2D errorState
		{
			get
			{
				return Collider2D.get_errorStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000345B File Offset: 0x0000165B
		public bool compositeCapable
		{
			get
			{
				return Collider2D.get_compositeCapableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000B014 File Offset: 0x00009214
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0000346D File Offset: 0x0000166D
		public PhysicsMaterial2D sharedMaterial
		{
			get
			{
				IntPtr intPtr = Collider2D.get_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsMaterial2D>(intPtr2) : null;
			}
			set
			{
				Collider2D.set_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00003485 File Offset: 0x00001685
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00003497 File Offset: 0x00001697
		public int layerOverridePriority
		{
			get
			{
				return Collider2D.get_layerOverridePriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider2D.set_layerOverridePriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000B040 File Offset: 0x00009240
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x000034AA File Offset: 0x000016AA
		public LayerMask excludeLayers
		{
			get
			{
				LayerMask layerMask;
				this.get_excludeLayers_Injected(out layerMask);
				return layerMask;
			}
			set
			{
				this.set_excludeLayers_Injected(ref value);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000B058 File Offset: 0x00009258
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x000034B4 File Offset: 0x000016B4
		public LayerMask includeLayers
		{
			get
			{
				LayerMask layerMask;
				this.get_includeLayers_Injected(out layerMask);
				return layerMask;
			}
			set
			{
				this.set_includeLayers_Injected(ref value);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000B070 File Offset: 0x00009270
		// (set) Token: 0x060002EA RID: 746 RVA: 0x000034BE File Offset: 0x000016BE
		public LayerMask forceSendLayers
		{
			get
			{
				LayerMask layerMask;
				this.get_forceSendLayers_Injected(out layerMask);
				return layerMask;
			}
			set
			{
				this.set_forceSendLayers_Injected(ref value);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000B088 File Offset: 0x00009288
		// (set) Token: 0x060002EC RID: 748 RVA: 0x000034C8 File Offset: 0x000016C8
		public LayerMask forceReceiveLayers
		{
			get
			{
				LayerMask layerMask;
				this.get_forceReceiveLayers_Injected(out layerMask);
				return layerMask;
			}
			set
			{
				this.set_forceReceiveLayers_Injected(ref value);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000B0A0 File Offset: 0x000092A0
		// (set) Token: 0x060002EE RID: 750 RVA: 0x000034D2 File Offset: 0x000016D2
		public LayerMask contactCaptureLayers
		{
			get
			{
				LayerMask layerMask;
				this.get_contactCaptureLayers_Injected(out layerMask);
				return layerMask;
			}
			set
			{
				this.set_contactCaptureLayers_Injected(ref value);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0000B0B8 File Offset: 0x000092B8
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x000034DC File Offset: 0x000016DC
		public LayerMask callbackLayers
		{
			get
			{
				LayerMask layerMask;
				this.get_callbackLayers_Injected(out layerMask);
				return layerMask;
			}
			set
			{
				this.set_callbackLayers_Injected(ref value);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x000034E6 File Offset: 0x000016E6
		public float friction
		{
			get
			{
				return Collider2D.get_frictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x000034F8 File Offset: 0x000016F8
		public float bounciness
		{
			get
			{
				return Collider2D.get_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000350A File Offset: 0x0000170A
		public bool IsTouching(Collider2D collider)
		{
			return Collider2D.IsTouchingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(collider));
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000B0D0 File Offset: 0x000092D0
		public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter)
		{
			return this.IsTouching_OtherColliderWithFilter(collider, contactFilter);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00003522 File Offset: 0x00001722
		public bool IsTouching_OtherColliderWithFilter(Collider2D collider, ContactFilter2D contactFilter)
		{
			return this.IsTouching_OtherColliderWithFilter_Injected(collider, ref contactFilter);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000B0EC File Offset: 0x000092EC
		public bool IsTouching(ContactFilter2D contactFilter)
		{
			return this.IsTouching_AnyColliderWithFilter(contactFilter);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000352D File Offset: 0x0000172D
		public bool IsTouching_AnyColliderWithFilter(ContactFilter2D contactFilter)
		{
			return this.IsTouching_AnyColliderWithFilter_Injected(ref contactFilter);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000B108 File Offset: 0x00009308
		public bool IsTouchingLayers()
		{
			return this.IsTouchingLayers(-1);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00003537 File Offset: 0x00001737
		public bool IsTouchingLayers(int layerMask)
		{
			return Collider2D.IsTouchingLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerMask);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000354A File Offset: 0x0000174A
		public bool OverlapPoint(Vector2 point)
		{
			return this.OverlapPoint_Injected(ref point);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000B124 File Offset: 0x00009324
		public int OverlapCollider(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCollider(this, contactFilter, results);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000B140 File Offset: 0x00009340
		public int OverlapCollider(ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCollider(this, contactFilter, results);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000B15C File Offset: 0x0000935C
		public int GetContacts(Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000B184 File Offset: 0x00009384
		public int GetContacts(List<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000B1AC File Offset: 0x000093AC
		public int GetContacts(ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, contactFilter, contacts);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000B1C8 File Offset: 0x000093C8
		public int GetContacts(ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, contactFilter, contacts);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000B1E4 File Offset: 0x000093E4
		public int GetContacts(Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000B20C File Offset: 0x0000940C
		public int GetContacts(List<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000B234 File Offset: 0x00009434
		public int GetContacts(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, contactFilter, colliders);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000B250 File Offset: 0x00009450
		public int GetContacts(ContactFilter2D contactFilter, List<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, contactFilter, colliders);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000B26C File Offset: 0x0000946C
		public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			ContactFilter2D contactFilter2D = default(ContactFilter2D);
			contactFilter2D.useTriggers = Physics2D.queriesHitTriggers;
			contactFilter2D.SetLayerMask(Physics2D.GetLayerCollisionMask(base.gameObject.layer));
			return this.CastArray_Internal(direction, float.PositiveInfinity, contactFilter2D, true, results);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000B2C0 File Offset: 0x000094C0
		public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			ContactFilter2D contactFilter2D = default(ContactFilter2D);
			contactFilter2D.useTriggers = Physics2D.queriesHitTriggers;
			contactFilter2D.SetLayerMask(Physics2D.GetLayerCollisionMask(base.gameObject.layer));
			return this.CastArray_Internal(direction, distance, contactFilter2D, true, results);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000B310 File Offset: 0x00009510
		public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, bool ignoreSiblingColliders)
		{
			ContactFilter2D contactFilter2D = default(ContactFilter2D);
			contactFilter2D.useTriggers = Physics2D.queriesHitTriggers;
			contactFilter2D.SetLayerMask(Physics2D.GetLayerCollisionMask(base.gameObject.layer));
			return this.CastArray_Internal(direction, distance, contactFilter2D, ignoreSiblingColliders, results);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000B360 File Offset: 0x00009560
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastArray_Internal(direction, float.PositiveInfinity, contactFilter, true, results);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000B384 File Offset: 0x00009584
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return this.CastArray_Internal(direction, distance, contactFilter, true, results);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000B3A4 File Offset: 0x000095A4
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance, bool ignoreSiblingColliders)
		{
			return this.CastArray_Internal(direction, distance, contactFilter, ignoreSiblingColliders, results);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00003554 File Offset: 0x00001754
		public int CastArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, bool ignoreSiblingColliders, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastArray_Internal_Injected(ref direction, distance, ref contactFilter, ignoreSiblingColliders, results);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000B3C4 File Offset: 0x000095C4
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance, [Optional] bool ignoreSiblingColliders)
		{
			return this.CastList_Internal(direction, distance, contactFilter, ignoreSiblingColliders, results);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00003565 File Offset: 0x00001765
		public int CastList_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, bool ignoreSiblingColliders, List<RaycastHit2D> results)
		{
			return this.CastList_Internal_Injected(ref direction, distance, ref contactFilter, ignoreSiblingColliders, results);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000B3E4 File Offset: 0x000095E4
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-1, float.NegativeInfinity, float.PositiveInfinity);
			return this.RaycastArray_Internal(direction, float.PositiveInfinity, contactFilter2D, results);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000B418 File Offset: 0x00009618
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-1, float.NegativeInfinity, float.PositiveInfinity);
			return this.RaycastArray_Internal(direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000B448 File Offset: 0x00009648
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return this.RaycastArray_Internal(direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000B478 File Offset: 0x00009678
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return this.RaycastArray_Internal(direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000B4A4 File Offset: 0x000096A4
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return this.RaycastArray_Internal(direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000B4CC File Offset: 0x000096CC
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.RaycastArray_Internal(direction, float.PositiveInfinity, contactFilter, results);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000B4EC File Offset: 0x000096EC
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return this.RaycastArray_Internal(direction, distance, contactFilter, results);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00003576 File Offset: 0x00001776
		public int RaycastArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.RaycastArray_Internal_Injected(ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000B50C File Offset: 0x0000970C
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
		{
			return this.RaycastList_Internal(direction, distance, contactFilter, results);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00003585 File Offset: 0x00001785
		public int RaycastList_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return this.RaycastList_Internal_Injected(ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000B52C File Offset: 0x0000972C
		public Vector2 ClosestPoint(Vector2 position)
		{
			return Physics2D.ClosestPoint(position, this);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00003594 File Offset: 0x00001794
		public void get_offset_Injected(out Vector2 ret)
		{
			Collider2D.get_offset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000035A7 File Offset: 0x000017A7
		public void set_offset_Injected(ref Vector2 value)
		{
			Collider2D.set_offset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000035BA File Offset: 0x000017BA
		public void get_excludeLayers_Injected(out LayerMask ret)
		{
			Collider2D.get_excludeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000035CD File Offset: 0x000017CD
		public void set_excludeLayers_Injected(ref LayerMask value)
		{
			Collider2D.set_excludeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000035E0 File Offset: 0x000017E0
		public void get_includeLayers_Injected(out LayerMask ret)
		{
			Collider2D.get_includeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000035F3 File Offset: 0x000017F3
		public void set_includeLayers_Injected(ref LayerMask value)
		{
			Collider2D.set_includeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00003606 File Offset: 0x00001806
		public void get_forceSendLayers_Injected(out LayerMask ret)
		{
			Collider2D.get_forceSendLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003619 File Offset: 0x00001819
		public void set_forceSendLayers_Injected(ref LayerMask value)
		{
			Collider2D.set_forceSendLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000362C File Offset: 0x0000182C
		public void get_forceReceiveLayers_Injected(out LayerMask ret)
		{
			Collider2D.get_forceReceiveLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000363F File Offset: 0x0000183F
		public void set_forceReceiveLayers_Injected(ref LayerMask value)
		{
			Collider2D.set_forceReceiveLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00003652 File Offset: 0x00001852
		public void get_contactCaptureLayers_Injected(out LayerMask ret)
		{
			Collider2D.get_contactCaptureLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00003665 File Offset: 0x00001865
		public void set_contactCaptureLayers_Injected(ref LayerMask value)
		{
			Collider2D.set_contactCaptureLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00003678 File Offset: 0x00001878
		public void get_callbackLayers_Injected(out LayerMask ret)
		{
			Collider2D.get_callbackLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000368B File Offset: 0x0000188B
		public void set_callbackLayers_Injected(ref LayerMask value)
		{
			Collider2D.set_callbackLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000369E File Offset: 0x0000189E
		public bool IsTouching_OtherColliderWithFilter_Injected(Collider2D collider, ref ContactFilter2D contactFilter)
		{
			return Collider2D.IsTouching_OtherColliderWithFilter_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000036B7 File Offset: 0x000018B7
		public bool IsTouching_AnyColliderWithFilter_Injected(ref ContactFilter2D contactFilter)
		{
			return Collider2D.IsTouching_AnyColliderWithFilter_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref contactFilter);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000036CA File Offset: 0x000018CA
		public bool OverlapPoint_Injected(ref Vector2 point)
		{
			return Collider2D.OverlapPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000036DD File Offset: 0x000018DD
		public int CastArray_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, bool ignoreSiblingColliders, Il2CppStructArray<RaycastHit2D> results)
		{
			return Collider2D.CastArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, ignoreSiblingColliders, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000036FB File Offset: 0x000018FB
		public int CastList_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, bool ignoreSiblingColliders, List<RaycastHit2D> results)
		{
			return Collider2D.CastList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, ignoreSiblingColliders, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00003719 File Offset: 0x00001919
		public int RaycastArray_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return Collider2D.RaycastArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00003735 File Offset: 0x00001935
		public int RaycastList_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return Collider2D.RaycastList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x04000135 RID: 309
		private static readonly Collider2D.get_densityDelegate get_densityDelegateField;

		// Token: 0x04000136 RID: 310
		private static readonly Collider2D.set_densityDelegate set_densityDelegateField;

		// Token: 0x04000137 RID: 311
		private static readonly Collider2D.get_isTriggerDelegate get_isTriggerDelegateField;

		// Token: 0x04000138 RID: 312
		private static readonly Collider2D.set_isTriggerDelegate set_isTriggerDelegateField;

		// Token: 0x04000139 RID: 313
		private static readonly Collider2D.get_usedByEffectorDelegate get_usedByEffectorDelegateField;

		// Token: 0x0400013A RID: 314
		private static readonly Collider2D.set_usedByEffectorDelegate set_usedByEffectorDelegateField;

		// Token: 0x0400013B RID: 315
		private static readonly Collider2D.get_usedByCompositeDelegate get_usedByCompositeDelegateField;

		// Token: 0x0400013C RID: 316
		private static readonly Collider2D.set_usedByCompositeDelegate set_usedByCompositeDelegateField;

		// Token: 0x0400013D RID: 317
		private static readonly Collider2D.get_compositeDelegate get_compositeDelegateField;

		// Token: 0x0400013E RID: 318
		private static readonly Collider2D.get_attachedRigidbodyDelegate get_attachedRigidbodyDelegateField;

		// Token: 0x0400013F RID: 319
		private static readonly Collider2D.get_shapeCountDelegate get_shapeCountDelegateField;

		// Token: 0x04000140 RID: 320
		private static readonly Collider2D.CreateMeshDelegate CreateMeshDelegateField;

		// Token: 0x04000141 RID: 321
		private static readonly Collider2D.GetShapeHashDelegate GetShapeHashDelegateField;

		// Token: 0x04000142 RID: 322
		private static readonly Collider2D.get_errorStateDelegate get_errorStateDelegateField;

		// Token: 0x04000143 RID: 323
		private static readonly Collider2D.get_compositeCapableDelegate get_compositeCapableDelegateField;

		// Token: 0x04000144 RID: 324
		private static readonly Collider2D.get_sharedMaterialDelegate get_sharedMaterialDelegateField;

		// Token: 0x04000145 RID: 325
		private static readonly Collider2D.set_sharedMaterialDelegate set_sharedMaterialDelegateField;

		// Token: 0x04000146 RID: 326
		private static readonly Collider2D.get_layerOverridePriorityDelegate get_layerOverridePriorityDelegateField;

		// Token: 0x04000147 RID: 327
		private static readonly Collider2D.set_layerOverridePriorityDelegate set_layerOverridePriorityDelegateField;

		// Token: 0x04000148 RID: 328
		private static readonly Collider2D.get_frictionDelegate get_frictionDelegateField;

		// Token: 0x04000149 RID: 329
		private static readonly Collider2D.get_bouncinessDelegate get_bouncinessDelegateField;

		// Token: 0x0400014A RID: 330
		private static readonly Collider2D.IsTouchingDelegate IsTouchingDelegateField;

		// Token: 0x0400014B RID: 331
		private static readonly Collider2D.IsTouchingLayersDelegate IsTouchingLayersDelegateField;

		// Token: 0x0400014C RID: 332
		private static readonly Collider2D.get_offset_InjectedDelegate get_offset_InjectedDelegateField;

		// Token: 0x0400014D RID: 333
		private static readonly Collider2D.set_offset_InjectedDelegate set_offset_InjectedDelegateField;

		// Token: 0x0400014E RID: 334
		private static readonly Collider2D.get_excludeLayers_InjectedDelegate get_excludeLayers_InjectedDelegateField;

		// Token: 0x0400014F RID: 335
		private static readonly Collider2D.set_excludeLayers_InjectedDelegate set_excludeLayers_InjectedDelegateField;

		// Token: 0x04000150 RID: 336
		private static readonly Collider2D.get_includeLayers_InjectedDelegate get_includeLayers_InjectedDelegateField;

		// Token: 0x04000151 RID: 337
		private static readonly Collider2D.set_includeLayers_InjectedDelegate set_includeLayers_InjectedDelegateField;

		// Token: 0x04000152 RID: 338
		private static readonly Collider2D.get_forceSendLayers_InjectedDelegate get_forceSendLayers_InjectedDelegateField;

		// Token: 0x04000153 RID: 339
		private static readonly Collider2D.set_forceSendLayers_InjectedDelegate set_forceSendLayers_InjectedDelegateField;

		// Token: 0x04000154 RID: 340
		private static readonly Collider2D.get_forceReceiveLayers_InjectedDelegate get_forceReceiveLayers_InjectedDelegateField;

		// Token: 0x04000155 RID: 341
		private static readonly Collider2D.set_forceReceiveLayers_InjectedDelegate set_forceReceiveLayers_InjectedDelegateField;

		// Token: 0x04000156 RID: 342
		private static readonly Collider2D.get_contactCaptureLayers_InjectedDelegate get_contactCaptureLayers_InjectedDelegateField;

		// Token: 0x04000157 RID: 343
		private static readonly Collider2D.set_contactCaptureLayers_InjectedDelegate set_contactCaptureLayers_InjectedDelegateField;

		// Token: 0x04000158 RID: 344
		private static readonly Collider2D.get_callbackLayers_InjectedDelegate get_callbackLayers_InjectedDelegateField;

		// Token: 0x04000159 RID: 345
		private static readonly Collider2D.set_callbackLayers_InjectedDelegate set_callbackLayers_InjectedDelegateField;

		// Token: 0x0400015A RID: 346
		private static readonly Collider2D.IsTouching_OtherColliderWithFilter_InjectedDelegate IsTouching_OtherColliderWithFilter_InjectedDelegateField;

		// Token: 0x0400015B RID: 347
		private static readonly Collider2D.IsTouching_AnyColliderWithFilter_InjectedDelegate IsTouching_AnyColliderWithFilter_InjectedDelegateField;

		// Token: 0x0400015C RID: 348
		private static readonly Collider2D.OverlapPoint_InjectedDelegate OverlapPoint_InjectedDelegateField;

		// Token: 0x0400015D RID: 349
		private static readonly Collider2D.CastArray_Internal_InjectedDelegate CastArray_Internal_InjectedDelegateField;

		// Token: 0x0400015E RID: 350
		private static readonly Collider2D.CastList_Internal_InjectedDelegate CastList_Internal_InjectedDelegateField;

		// Token: 0x0400015F RID: 351
		private static readonly Collider2D.RaycastArray_Internal_InjectedDelegate RaycastArray_Internal_InjectedDelegateField;

		// Token: 0x04000160 RID: 352
		private static readonly Collider2D.RaycastList_Internal_InjectedDelegate RaycastList_Internal_InjectedDelegateField;

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x06000612 RID: 1554
		private delegate float get_densityDelegate(IntPtr @this);

		// Token: 0x020000F4 RID: 244
		// (Invoke) Token: 0x06000614 RID: 1556
		private delegate void set_densityDelegate(IntPtr @this, float value);

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x06000616 RID: 1558
		private delegate bool get_isTriggerDelegate(IntPtr @this);

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x06000618 RID: 1560
		private delegate void set_isTriggerDelegate(IntPtr @this, bool value);

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x0600061A RID: 1562
		private delegate bool get_usedByEffectorDelegate(IntPtr @this);

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x0600061C RID: 1564
		private delegate void set_usedByEffectorDelegate(IntPtr @this, bool value);

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x0600061E RID: 1566
		private delegate bool get_usedByCompositeDelegate(IntPtr @this);

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x06000620 RID: 1568
		private delegate void set_usedByCompositeDelegate(IntPtr @this, bool value);

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x06000622 RID: 1570
		private delegate IntPtr get_compositeDelegate(IntPtr @this);

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x06000624 RID: 1572
		private delegate IntPtr get_attachedRigidbodyDelegate(IntPtr @this);

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x06000626 RID: 1574
		private delegate int get_shapeCountDelegate(IntPtr @this);

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x06000628 RID: 1576
		private delegate IntPtr CreateMeshDelegate(IntPtr @this, bool useBodyPosition, bool useBodyRotation);

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x0600062A RID: 1578
		private delegate uint GetShapeHashDelegate(IntPtr @this);

		// Token: 0x02000100 RID: 256
		// (Invoke) Token: 0x0600062C RID: 1580
		private delegate ColliderErrorState2D get_errorStateDelegate(IntPtr @this);

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x0600062E RID: 1582
		private delegate bool get_compositeCapableDelegate(IntPtr @this);

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x06000630 RID: 1584
		private delegate IntPtr get_sharedMaterialDelegate(IntPtr @this);

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x06000632 RID: 1586
		private delegate void set_sharedMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x06000634 RID: 1588
		private delegate int get_layerOverridePriorityDelegate(IntPtr @this);

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x06000636 RID: 1590
		private delegate void set_layerOverridePriorityDelegate(IntPtr @this, int value);

		// Token: 0x02000106 RID: 262
		// (Invoke) Token: 0x06000638 RID: 1592
		private delegate float get_frictionDelegate(IntPtr @this);

		// Token: 0x02000107 RID: 263
		// (Invoke) Token: 0x0600063A RID: 1594
		private delegate float get_bouncinessDelegate(IntPtr @this);

		// Token: 0x02000108 RID: 264
		// (Invoke) Token: 0x0600063C RID: 1596
		private delegate bool IsTouchingDelegate(IntPtr @this, IntPtr collider);

		// Token: 0x02000109 RID: 265
		// (Invoke) Token: 0x0600063E RID: 1598
		private delegate bool IsTouchingLayersDelegate(IntPtr @this, int layerMask);

		// Token: 0x0200010A RID: 266
		// (Invoke) Token: 0x06000640 RID: 1600
		private delegate void get_offset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200010B RID: 267
		// (Invoke) Token: 0x06000642 RID: 1602
		private delegate void set_offset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200010C RID: 268
		// (Invoke) Token: 0x06000644 RID: 1604
		private delegate void get_excludeLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x06000646 RID: 1606
		private delegate void set_excludeLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200010E RID: 270
		// (Invoke) Token: 0x06000648 RID: 1608
		private delegate void get_includeLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x0600064A RID: 1610
		private delegate void set_includeLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000110 RID: 272
		// (Invoke) Token: 0x0600064C RID: 1612
		private delegate void get_forceSendLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000111 RID: 273
		// (Invoke) Token: 0x0600064E RID: 1614
		private delegate void set_forceSendLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000112 RID: 274
		// (Invoke) Token: 0x06000650 RID: 1616
		private delegate void get_forceReceiveLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000113 RID: 275
		// (Invoke) Token: 0x06000652 RID: 1618
		private delegate void set_forceReceiveLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000114 RID: 276
		// (Invoke) Token: 0x06000654 RID: 1620
		private delegate void get_contactCaptureLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000115 RID: 277
		// (Invoke) Token: 0x06000656 RID: 1622
		private delegate void set_contactCaptureLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000116 RID: 278
		// (Invoke) Token: 0x06000658 RID: 1624
		private delegate void get_callbackLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000117 RID: 279
		// (Invoke) Token: 0x0600065A RID: 1626
		private delegate void set_callbackLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000118 RID: 280
		// (Invoke) Token: 0x0600065C RID: 1628
		private delegate bool IsTouching_OtherColliderWithFilter_InjectedDelegate(IntPtr @this, IntPtr collider, IntPtr contactFilter);

		// Token: 0x02000119 RID: 281
		// (Invoke) Token: 0x0600065E RID: 1630
		private delegate bool IsTouching_AnyColliderWithFilter_InjectedDelegate(IntPtr @this, IntPtr contactFilter);

		// Token: 0x0200011A RID: 282
		// (Invoke) Token: 0x06000660 RID: 1632
		private delegate bool OverlapPoint_InjectedDelegate(IntPtr @this, IntPtr point);

		// Token: 0x0200011B RID: 283
		// (Invoke) Token: 0x06000662 RID: 1634
		private delegate int CastArray_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, bool ignoreSiblingColliders, IntPtr results);

		// Token: 0x0200011C RID: 284
		// (Invoke) Token: 0x06000664 RID: 1636
		private delegate int CastList_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, bool ignoreSiblingColliders, IntPtr results);

		// Token: 0x0200011D RID: 285
		// (Invoke) Token: 0x06000666 RID: 1638
		private delegate int RaycastArray_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200011E RID: 286
		// (Invoke) Token: 0x06000668 RID: 1640
		private delegate int RaycastList_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);
	}
}
