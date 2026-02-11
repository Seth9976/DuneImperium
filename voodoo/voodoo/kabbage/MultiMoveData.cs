using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace voodoo.kabbage
{
	// Token: 0x02000026 RID: 38
	public class MultiMoveData : MonoBehaviour
	{
		// Token: 0x0600014D RID: 333 RVA: 0x0000D184 File Offset: 0x0000B384
		// Note: this type is marked as 'beforefieldinit'.
		static MultiMoveData()
		{
			Il2CppClassPointerStore<MultiMoveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "MultiMoveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiMoveData>.NativeClassPtr);
			MultiMoveData.NativeFieldInfoPtr_minimumStaggerDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiMoveData>.NativeClassPtr, "minimumStaggerDelay");
			MultiMoveData.NativeFieldInfoPtr_maximumStaggerDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiMoveData>.NativeClassPtr, "maximumStaggerDelay");
			MultiMoveData.NativeFieldInfoPtr_FXUnitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiMoveData>.NativeClassPtr, "FXUnitCount");
			MultiMoveData.NativeMethodInfoPtr_HasStagger_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiMoveData>.NativeClassPtr, 100663428);
			MultiMoveData.NativeMethodInfoPtr_GetStagger_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiMoveData>.NativeClassPtr, 100663429);
			MultiMoveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiMoveData>.NativeClassPtr, 100663430);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000D22C File Offset: 0x0000B42C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasStagger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiMoveData.NativeMethodInfoPtr_HasStagger_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000D268 File Offset: 0x0000B468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107144, XrefRangeEnd = 1107145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetStagger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiMoveData.NativeMethodInfoPtr_GetStagger_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000D2A4 File Offset: 0x0000B4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107145, XrefRangeEnd = 1107146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiMoveData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiMoveData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiMoveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002BD2 File Offset: 0x00000DD2
		public MultiMoveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00002BDB File Offset: 0x00000DDB
		public unsafe float minimumStaggerDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiMoveData.NativeFieldInfoPtr_minimumStaggerDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiMoveData.NativeFieldInfoPtr_minimumStaggerDelay)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000D308 File Offset: 0x0000B508
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00002BF6 File Offset: 0x00000DF6
		public unsafe float maximumStaggerDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiMoveData.NativeFieldInfoPtr_maximumStaggerDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiMoveData.NativeFieldInfoPtr_maximumStaggerDelay)) = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000D330 File Offset: 0x0000B530
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00002C11 File Offset: 0x00000E11
		public unsafe int FXUnitCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiMoveData.NativeFieldInfoPtr_FXUnitCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiMoveData.NativeFieldInfoPtr_FXUnitCount)) = value;
			}
		}

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_minimumStaggerDelay;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_maximumStaggerDelay;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_FXUnitCount;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_HasStagger_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_GetStagger_Public_Virtual_Final_New_Single_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
