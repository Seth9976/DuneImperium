using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public class Collider : Component
	{
		// Token: 0x06000218 RID: 536 RVA: 0x00008C70 File Offset: 0x00006E70
		// Note: this type is marked as 'beforefieldinit'.
		static Collider()
		{
			Il2CppClassPointerStore<Collider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Collider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collider>.NativeClassPtr);
			Collider.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663375);
			Collider.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663376);
			Collider.NativeMethodInfoPtr_get_attachedRigidbody_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663377);
			Collider.NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663378);
			Collider.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663379);
			Collider.NativeMethodInfoPtr_Raycast_Private_RaycastHit_Ray_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663380);
			Collider.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663381);
			Collider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663382);
			Collider.NativeMethodInfoPtr_ClosestPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663383);
			Collider.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663384);
			Collider.NativeMethodInfoPtr_Raycast_Injected_Private_Void_byref_Ray_Single_byref_Boolean_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663385);
			Collider.get_attachedArticulationBodyDelegateField = IL2CPP.ResolveICall<Collider.get_attachedArticulationBodyDelegate>("UnityEngine.Collider::get_attachedArticulationBody");
			Collider.get_isTriggerDelegateField = IL2CPP.ResolveICall<Collider.get_isTriggerDelegate>("UnityEngine.Collider::get_isTrigger");
			Collider.set_isTriggerDelegateField = IL2CPP.ResolveICall<Collider.set_isTriggerDelegate>("UnityEngine.Collider::set_isTrigger");
			Collider.get_contactOffsetDelegateField = IL2CPP.ResolveICall<Collider.get_contactOffsetDelegate>("UnityEngine.Collider::get_contactOffset");
			Collider.set_contactOffsetDelegateField = IL2CPP.ResolveICall<Collider.set_contactOffsetDelegate>("UnityEngine.Collider::set_contactOffset");
			Collider.get_hasModifiableContactsDelegateField = IL2CPP.ResolveICall<Collider.get_hasModifiableContactsDelegate>("UnityEngine.Collider::get_hasModifiableContacts");
			Collider.set_hasModifiableContactsDelegateField = IL2CPP.ResolveICall<Collider.set_hasModifiableContactsDelegate>("UnityEngine.Collider::set_hasModifiableContacts");
			Collider.get_providesContactsDelegateField = IL2CPP.ResolveICall<Collider.get_providesContactsDelegate>("UnityEngine.Collider::get_providesContacts");
			Collider.set_providesContactsDelegateField = IL2CPP.ResolveICall<Collider.set_providesContactsDelegate>("UnityEngine.Collider::set_providesContacts");
			Collider.get_layerOverridePriorityDelegateField = IL2CPP.ResolveICall<Collider.get_layerOverridePriorityDelegate>("UnityEngine.Collider::get_layerOverridePriority");
			Collider.set_layerOverridePriorityDelegateField = IL2CPP.ResolveICall<Collider.set_layerOverridePriorityDelegate>("UnityEngine.Collider::set_layerOverridePriority");
			Collider.get_sharedMaterialDelegateField = IL2CPP.ResolveICall<Collider.get_sharedMaterialDelegate>("UnityEngine.Collider::get_sharedMaterial");
			Collider.set_sharedMaterialDelegateField = IL2CPP.ResolveICall<Collider.set_sharedMaterialDelegate>("UnityEngine.Collider::set_sharedMaterial");
			Collider.get_materialDelegateField = IL2CPP.ResolveICall<Collider.get_materialDelegate>("UnityEngine.Collider::get_material");
			Collider.set_materialDelegateField = IL2CPP.ResolveICall<Collider.set_materialDelegate>("UnityEngine.Collider::set_material");
			Collider.get_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider.get_excludeLayers_InjectedDelegate>("UnityEngine.Collider::get_excludeLayers_Injected");
			Collider.set_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider.set_excludeLayers_InjectedDelegate>("UnityEngine.Collider::set_excludeLayers_Injected");
			Collider.get_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider.get_includeLayers_InjectedDelegate>("UnityEngine.Collider::get_includeLayers_Injected");
			Collider.set_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Collider.set_includeLayers_InjectedDelegate>("UnityEngine.Collider::set_includeLayers_Injected");
			Collider.Internal_ClosestPointOnBounds_InjectedDelegateField = IL2CPP.ResolveICall<Collider.Internal_ClosestPointOnBounds_InjectedDelegate>("UnityEngine.Collider::Internal_ClosestPointOnBounds_Injected");
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00008EA8 File Offset: 0x000070A8
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00008EE4 File Offset: 0x000070E4
		public unsafe bool enabled
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1255113, RefRangeEnd = 1255116, XrefRangeStart = 1255111, XrefRangeEnd = 1255113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1255118, RefRangeEnd = 1255124, XrefRangeStart = 1255116, XrefRangeEnd = 1255118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00008F24 File Offset: 0x00007124
		public unsafe Rigidbody attachedRigidbody
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255124, XrefRangeEnd = 1255126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_get_attachedRigidbody_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr3) : null;
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00008F64 File Offset: 0x00007164
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1255128, RefRangeEnd = 1255130, XrefRangeStart = 1255126, XrefRangeEnd = 1255128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ClosestPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00008FB0 File Offset: 0x000071B0
		public unsafe Bounds bounds
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1255132, RefRangeEnd = 1255133, XrefRangeStart = 1255130, XrefRangeEnd = 1255132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00008FEC File Offset: 0x000071EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255133, XrefRangeEnd = 1255135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasHit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_Raycast_Private_RaycastHit_Ray_Single_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00009054 File Offset: 0x00007254
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1255137, RefRangeEnd = 1255138, XrefRangeStart = 1255135, XrefRangeEnd = 1255137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_RaycastHit_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000090BC File Offset: 0x000072BC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000090F8 File Offset: 0x000072F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255138, XrefRangeEnd = 1255140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_ClosestPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00009144 File Offset: 0x00007344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255140, XrefRangeEnd = 1255142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00009184 File Offset: 0x00007384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255142, XrefRangeEnd = 1255144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasHit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_Raycast_Injected_Private_Void_byref_Ray_Single_byref_Boolean_byref_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000300A File Offset: 0x0000120A
		public Collider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000091F0 File Offset: 0x000073F0
		public ArticulationBody attachedArticulationBody
		{
			get
			{
				IntPtr intPtr = Collider.get_attachedArticulationBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArticulationBody>(intPtr2) : null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00003013 File Offset: 0x00001213
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00003025 File Offset: 0x00001225
		public bool isTrigger
		{
			get
			{
				return Collider.get_isTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider.set_isTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00003038 File Offset: 0x00001238
		// (set) Token: 0x06000229 RID: 553 RVA: 0x0000304A File Offset: 0x0000124A
		public float contactOffset
		{
			get
			{
				return Collider.get_contactOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider.set_contactOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0000305D File Offset: 0x0000125D
		// (set) Token: 0x0600022B RID: 555 RVA: 0x0000306F File Offset: 0x0000126F
		public bool hasModifiableContacts
		{
			get
			{
				return Collider.get_hasModifiableContactsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider.set_hasModifiableContactsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00003082 File Offset: 0x00001282
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00003094 File Offset: 0x00001294
		public bool providesContacts
		{
			get
			{
				return Collider.get_providesContactsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider.set_providesContactsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600022E RID: 558 RVA: 0x000030A7 File Offset: 0x000012A7
		// (set) Token: 0x0600022F RID: 559 RVA: 0x000030B9 File Offset: 0x000012B9
		public int layerOverridePriority
		{
			get
			{
				return Collider.get_layerOverridePriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider.set_layerOverridePriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000921C File Offset: 0x0000741C
		// (set) Token: 0x06000231 RID: 561 RVA: 0x000030CC File Offset: 0x000012CC
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

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00009234 File Offset: 0x00007434
		// (set) Token: 0x06000233 RID: 563 RVA: 0x000030D6 File Offset: 0x000012D6
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

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0000924C File Offset: 0x0000744C
		// (set) Token: 0x06000235 RID: 565 RVA: 0x000030E0 File Offset: 0x000012E0
		public PhysicMaterial sharedMaterial
		{
			get
			{
				IntPtr intPtr = Collider.get_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicMaterial>(intPtr2) : null;
			}
			set
			{
				Collider.set_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00009278 File Offset: 0x00007478
		// (set) Token: 0x06000237 RID: 567 RVA: 0x000030F8 File Offset: 0x000012F8
		public PhysicMaterial material
		{
			get
			{
				IntPtr intPtr = Collider.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicMaterial>(intPtr2) : null;
			}
			set
			{
				Collider.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00003110 File Offset: 0x00001310
		public void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance)
		{
			this.Internal_ClosestPointOnBounds_Injected(ref point, ref outPos, ref distance);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000092A4 File Offset: 0x000074A4
		public Vector3 ClosestPointOnBounds(Vector3 position)
		{
			float num = 0f;
			Vector3 zero = Vector3.zero;
			this.Internal_ClosestPointOnBounds(position, ref zero, ref num);
			return zero;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000311C File Offset: 0x0000131C
		public void get_excludeLayers_Injected(out LayerMask ret)
		{
			Collider.get_excludeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000312F File Offset: 0x0000132F
		public void set_excludeLayers_Injected(ref LayerMask value)
		{
			Collider.set_excludeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00003142 File Offset: 0x00001342
		public void get_includeLayers_Injected(out LayerMask ret)
		{
			Collider.get_includeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00003155 File Offset: 0x00001355
		public void set_includeLayers_Injected(ref LayerMask value)
		{
			Collider.set_includeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00003168 File Offset: 0x00001368
		public void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance)
		{
			Collider.Internal_ClosestPointOnBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, ref outPos, ref distance);
		}

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_get_attachedRigidbody_Public_get_Rigidbody_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Private_RaycastHit_Ray_Single_byref_Boolean_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_RaycastHit_Single_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_ClosestPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Injected_Private_Void_byref_Ray_Single_byref_Boolean_byref_RaycastHit_0;

		// Token: 0x04000125 RID: 293
		private static readonly Collider.get_attachedArticulationBodyDelegate get_attachedArticulationBodyDelegateField;

		// Token: 0x04000126 RID: 294
		private static readonly Collider.get_isTriggerDelegate get_isTriggerDelegateField;

		// Token: 0x04000127 RID: 295
		private static readonly Collider.set_isTriggerDelegate set_isTriggerDelegateField;

		// Token: 0x04000128 RID: 296
		private static readonly Collider.get_contactOffsetDelegate get_contactOffsetDelegateField;

		// Token: 0x04000129 RID: 297
		private static readonly Collider.set_contactOffsetDelegate set_contactOffsetDelegateField;

		// Token: 0x0400012A RID: 298
		private static readonly Collider.get_hasModifiableContactsDelegate get_hasModifiableContactsDelegateField;

		// Token: 0x0400012B RID: 299
		private static readonly Collider.set_hasModifiableContactsDelegate set_hasModifiableContactsDelegateField;

		// Token: 0x0400012C RID: 300
		private static readonly Collider.get_providesContactsDelegate get_providesContactsDelegateField;

		// Token: 0x0400012D RID: 301
		private static readonly Collider.set_providesContactsDelegate set_providesContactsDelegateField;

		// Token: 0x0400012E RID: 302
		private static readonly Collider.get_layerOverridePriorityDelegate get_layerOverridePriorityDelegateField;

		// Token: 0x0400012F RID: 303
		private static readonly Collider.set_layerOverridePriorityDelegate set_layerOverridePriorityDelegateField;

		// Token: 0x04000130 RID: 304
		private static readonly Collider.get_sharedMaterialDelegate get_sharedMaterialDelegateField;

		// Token: 0x04000131 RID: 305
		private static readonly Collider.set_sharedMaterialDelegate set_sharedMaterialDelegateField;

		// Token: 0x04000132 RID: 306
		private static readonly Collider.get_materialDelegate get_materialDelegateField;

		// Token: 0x04000133 RID: 307
		private static readonly Collider.set_materialDelegate set_materialDelegateField;

		// Token: 0x04000134 RID: 308
		private static readonly Collider.get_excludeLayers_InjectedDelegate get_excludeLayers_InjectedDelegateField;

		// Token: 0x04000135 RID: 309
		private static readonly Collider.set_excludeLayers_InjectedDelegate set_excludeLayers_InjectedDelegateField;

		// Token: 0x04000136 RID: 310
		private static readonly Collider.get_includeLayers_InjectedDelegate get_includeLayers_InjectedDelegateField;

		// Token: 0x04000137 RID: 311
		private static readonly Collider.set_includeLayers_InjectedDelegate set_includeLayers_InjectedDelegateField;

		// Token: 0x04000138 RID: 312
		private static readonly Collider.Internal_ClosestPointOnBounds_InjectedDelegate Internal_ClosestPointOnBounds_InjectedDelegateField;

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x0600054E RID: 1358
		private delegate IntPtr get_attachedArticulationBodyDelegate(IntPtr @this);

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x06000550 RID: 1360
		private delegate bool get_isTriggerDelegate(IntPtr @this);

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x06000552 RID: 1362
		private delegate void set_isTriggerDelegate(IntPtr @this, bool value);

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x06000554 RID: 1364
		private delegate float get_contactOffsetDelegate(IntPtr @this);

		// Token: 0x020000BF RID: 191
		// (Invoke) Token: 0x06000556 RID: 1366
		private delegate void set_contactOffsetDelegate(IntPtr @this, float value);

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x06000558 RID: 1368
		private delegate bool get_hasModifiableContactsDelegate(IntPtr @this);

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x0600055A RID: 1370
		private delegate void set_hasModifiableContactsDelegate(IntPtr @this, bool value);

		// Token: 0x020000C2 RID: 194
		// (Invoke) Token: 0x0600055C RID: 1372
		private delegate bool get_providesContactsDelegate(IntPtr @this);

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x0600055E RID: 1374
		private delegate void set_providesContactsDelegate(IntPtr @this, bool value);

		// Token: 0x020000C4 RID: 196
		// (Invoke) Token: 0x06000560 RID: 1376
		private delegate int get_layerOverridePriorityDelegate(IntPtr @this);

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x06000562 RID: 1378
		private delegate void set_layerOverridePriorityDelegate(IntPtr @this, int value);

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x06000564 RID: 1380
		private delegate IntPtr get_sharedMaterialDelegate(IntPtr @this);

		// Token: 0x020000C7 RID: 199
		// (Invoke) Token: 0x06000566 RID: 1382
		private delegate void set_sharedMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000C8 RID: 200
		// (Invoke) Token: 0x06000568 RID: 1384
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x0600056A RID: 1386
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x0600056C RID: 1388
		private delegate void get_excludeLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000CB RID: 203
		// (Invoke) Token: 0x0600056E RID: 1390
		private delegate void set_excludeLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000CC RID: 204
		// (Invoke) Token: 0x06000570 RID: 1392
		private delegate void get_includeLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x06000572 RID: 1394
		private delegate void set_includeLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x06000574 RID: 1396
		private delegate void Internal_ClosestPointOnBounds_InjectedDelegate(IntPtr @this, IntPtr point, IntPtr outPos, IntPtr distance);
	}
}
