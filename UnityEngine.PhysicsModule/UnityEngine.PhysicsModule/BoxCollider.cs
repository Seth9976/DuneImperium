using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	public class BoxCollider : Collider
	{
		// Token: 0x0600027C RID: 636 RVA: 0x000099FC File Offset: 0x00007BFC
		// Note: this type is marked as 'beforefieldinit'.
		static BoxCollider()
		{
			Il2CppClassPointerStore<BoxCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "BoxCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr);
			BoxCollider.NativeMethodInfoPtr_get_center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663399);
			BoxCollider.NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663400);
			BoxCollider.NativeMethodInfoPtr_get_size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663401);
			BoxCollider.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663402);
			BoxCollider.NativeMethodInfoPtr_get_extents_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663403);
			BoxCollider.NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663404);
			BoxCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663405);
			BoxCollider.NativeMethodInfoPtr_get_center_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663406);
			BoxCollider.NativeMethodInfoPtr_set_center_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663407);
			BoxCollider.NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663408);
			BoxCollider.NativeMethodInfoPtr_set_size_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663409);
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00009B08 File Offset: 0x00007D08
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00009B44 File Offset: 0x00007D44
		public unsafe Vector3 center
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1255159, RefRangeEnd = 1255161, XrefRangeStart = 1255157, XrefRangeEnd = 1255159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_get_center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1255163, RefRangeEnd = 1255164, XrefRangeStart = 1255161, XrefRangeEnd = 1255163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00009B84 File Offset: 0x00007D84
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00009BC0 File Offset: 0x00007DC0
		public unsafe Vector3 size
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1255166, RefRangeEnd = 1255171, XrefRangeStart = 1255164, XrefRangeEnd = 1255166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_get_size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1255173, RefRangeEnd = 1255175, XrefRangeStart = 1255171, XrefRangeEnd = 1255173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00009C00 File Offset: 0x00007E00
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00009C3C File Offset: 0x00007E3C
		public unsafe Vector3 extents
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255175, XrefRangeEnd = 1255177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_get_extents_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255177, XrefRangeEnd = 1255179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00009C7C File Offset: 0x00007E7C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoxCollider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00009CB8 File Offset: 0x00007EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255179, XrefRangeEnd = 1255181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_center_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_get_center_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00009CF8 File Offset: 0x00007EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255181, XrefRangeEnd = 1255183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_center_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_set_center_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00009D38 File Offset: 0x00007F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255183, XrefRangeEnd = 1255185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_size_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00009D78 File Offset: 0x00007F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255185, XrefRangeEnd = 1255187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_size_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_set_size_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00003426 File Offset: 0x00001626
		public BoxCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector3_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_get_extents_Public_get_Vector3_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_set_center_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Injected_Private_Void_byref_Vector3_0;
	}
}
