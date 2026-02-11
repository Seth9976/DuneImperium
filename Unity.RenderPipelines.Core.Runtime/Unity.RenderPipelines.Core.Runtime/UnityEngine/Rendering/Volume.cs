using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x020000E7 RID: 231
	public class Volume : MonoBehaviour
	{
		// Token: 0x06001094 RID: 4244 RVA: 0x0004C608 File Offset: 0x0004A808
		// Note: this type is marked as 'beforefieldinit'.
		static Volume()
		{
			Il2CppClassPointerStore<Volume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "Volume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Volume>.NativeClassPtr);
			Volume.NativeFieldInfoPtr_m_IsGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "m_IsGlobal");
			Volume.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "priority");
			Volume.NativeFieldInfoPtr_blendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "blendDistance");
			Volume.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "weight");
			Volume.NativeFieldInfoPtr_sharedProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "sharedProfile");
			Volume.NativeFieldInfoPtr_m_Colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "m_Colliders");
			Volume.NativeFieldInfoPtr_m_PreviousLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "m_PreviousLayer");
			Volume.NativeFieldInfoPtr_m_PreviousPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "m_PreviousPriority");
			Volume.NativeFieldInfoPtr_m_InternalProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "m_InternalProfile");
			Volume.NativeMethodInfoPtr_get_isGlobal_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665750);
			Volume.NativeMethodInfoPtr_set_isGlobal_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665751);
			Volume.NativeMethodInfoPtr_get_profile_Public_get_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665752);
			Volume.NativeMethodInfoPtr_set_profile_Public_set_Void_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665753);
			Volume.NativeMethodInfoPtr_get_colliders_Public_Virtual_Final_New_get_List_1_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665754);
			Volume.NativeMethodInfoPtr_get_profileRef_Internal_get_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665755);
			Volume.NativeMethodInfoPtr_HasInstantiatedProfile_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665756);
			Volume.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665757);
			Volume.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665758);
			Volume.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665759);
			Volume.NativeMethodInfoPtr_UpdateLayer_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665760);
			Volume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665761);
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x0004C7DC File Offset: 0x0004A9DC
		// (set) Token: 0x06001096 RID: 4246 RVA: 0x0004C818 File Offset: 0x0004AA18
		public unsafe virtual bool isGlobal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volume.NativeMethodInfoPtr_get_isGlobal_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volume.NativeMethodInfoPtr_set_isGlobal_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0004C858 File Offset: 0x0004AA58
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x0004C898 File Offset: 0x0004AA98
		public unsafe VolumeProfile profile
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 977970, RefRangeEnd = 977974, XrefRangeStart = 977933, XrefRangeEnd = 977970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volume.NativeMethodInfoPtr_get_profile_Public_get_VolumeProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeProfile>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volume.NativeMethodInfoPtr_set_profile_Public_set_Void_VolumeProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0004C8DC File Offset: 0x0004AADC
		public unsafe virtual List<Collider> colliders
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volume.NativeMethodInfoPtr_get_colliders_Public_Virtual_Final_New_get_List_1_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr3) : null;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x0004C91C File Offset: 0x0004AB1C
		public unsafe VolumeProfile profileRef
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 977978, RefRangeEnd = 977983, XrefRangeStart = 977974, XrefRangeEnd = 977978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volume.NativeMethodInfoPtr_get_profileRef_Internal_get_VolumeProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeProfile>(intPtr3) : null;
			}
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0004C95C File Offset: 0x0004AB5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 977987, RefRangeEnd = 977991, XrefRangeStart = 977983, XrefRangeEnd = 977987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasInstantiatedProfile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volume.NativeMethodInfoPtr_HasInstantiatedProfile_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0004C998 File Offset: 0x0004AB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977991, XrefRangeEnd = 978002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volume.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0004C9CC File Offset: 0x0004ABCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978002, XrefRangeEnd = 978010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volume.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0004CA00 File Offset: 0x0004AC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978010, XrefRangeEnd = 978025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volume.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0004CA34 File Offset: 0x0004AC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978025, XrefRangeEnd = 978033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volume.NativeMethodInfoPtr_UpdateLayer_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0004CA68 File Offset: 0x0004AC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978033, XrefRangeEnd = 978041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Volume()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Volume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00008BBF File Offset: 0x00006DBF
		public Volume(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0004CAA4 File Offset: 0x0004ACA4
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x00008BC8 File Offset: 0x00006DC8
		public unsafe bool m_IsGlobal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_m_IsGlobal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_m_IsGlobal)) = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x0004CACC File Offset: 0x0004ACCC
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x00008BE3 File Offset: 0x00006DE3
		public unsafe float priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x0004CAF4 File Offset: 0x0004ACF4
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x00008BFE File Offset: 0x00006DFE
		public unsafe float blendDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_blendDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_blendDistance)) = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x0004CB1C File Offset: 0x0004AD1C
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x00008C19 File Offset: 0x00006E19
		public unsafe float weight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_weight)) = value;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x0004CB44 File Offset: 0x0004AD44
		// (set) Token: 0x060010AB RID: 4267 RVA: 0x00008C34 File Offset: 0x00006E34
		public unsafe VolumeProfile sharedProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_sharedProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_sharedProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x0004CB74 File Offset: 0x0004AD74
		// (set) Token: 0x060010AD RID: 4269 RVA: 0x00008C53 File Offset: 0x00006E53
		public unsafe List<Collider> m_Colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_m_Colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_m_Colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x0004CBA4 File Offset: 0x0004ADA4
		// (set) Token: 0x060010AF RID: 4271 RVA: 0x00008C72 File Offset: 0x00006E72
		public unsafe int m_PreviousLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_m_PreviousLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_m_PreviousLayer)) = value;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x0004CBCC File Offset: 0x0004ADCC
		// (set) Token: 0x060010B1 RID: 4273 RVA: 0x00008C8D File Offset: 0x00006E8D
		public unsafe float m_PreviousPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_m_PreviousPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_m_PreviousPriority)) = value;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x0004CBF4 File Offset: 0x0004ADF4
		// (set) Token: 0x060010B3 RID: 4275 RVA: 0x00008CA8 File Offset: 0x00006EA8
		public unsafe VolumeProfile m_InternalProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_m_InternalProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volume.NativeFieldInfoPtr_m_InternalProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeFieldInfoPtr_m_IsGlobal;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeFieldInfoPtr_blendDistance;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeFieldInfoPtr_weight;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeFieldInfoPtr_sharedProfile;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeFieldInfoPtr_m_Colliders;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousLayer;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousPriority;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalProfile;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_get_isGlobal_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_set_isGlobal_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_get_profile_Public_get_VolumeProfile_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_set_profile_Public_set_Void_VolumeProfile_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_get_colliders_Public_Virtual_Final_New_get_List_1_Collider_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_get_profileRef_Internal_get_VolumeProfile_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_HasInstantiatedProfile_Public_Boolean_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLayer_Internal_Void_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
