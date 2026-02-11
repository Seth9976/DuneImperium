using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x02000007 RID: 7
	public class DestroyAfter : MonoBehaviour
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00003830 File Offset: 0x00001A30
		// Note: this type is marked as 'beforefieldinit'.
		static DestroyAfter()
		{
			Il2CppClassPointerStore<DestroyAfter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "DestroyAfter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyAfter>.NativeClassPtr);
			DestroyAfter.NativeFieldInfoPtr_destroyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfter>.NativeClassPtr, "destroyTime");
			DestroyAfter.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfter>.NativeClassPtr, "startTime");
			DestroyAfter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyAfter>.NativeClassPtr, 100663328);
			DestroyAfter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyAfter>.NativeClassPtr, 100663329);
			DestroyAfter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyAfter>.NativeClassPtr, 100663330);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000038C4 File Offset: 0x00001AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263221, XrefRangeEnd = 1263222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyAfter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000038F8 File Offset: 0x00001AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263222, XrefRangeEnd = 1263229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyAfter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000392C File Offset: 0x00001B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263229, XrefRangeEnd = 1263230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DestroyAfter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyAfter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyAfter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002273 File Offset: 0x00000473
		public DestroyAfter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003968 File Offset: 0x00001B68
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000227C File Offset: 0x0000047C
		public unsafe float destroyTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyAfter.NativeFieldInfoPtr_destroyTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyAfter.NativeFieldInfoPtr_destroyTime)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003990 File Offset: 0x00001B90
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002297 File Offset: 0x00000497
		public unsafe float startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyAfter.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyAfter.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_destroyTime;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
