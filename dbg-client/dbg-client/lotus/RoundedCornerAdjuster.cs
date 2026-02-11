using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200001C RID: 28
	public class RoundedCornerAdjuster : MonoBehaviour
	{
		// Token: 0x06000112 RID: 274 RVA: 0x000210F0 File Offset: 0x0001F2F0
		// Note: this type is marked as 'beforefieldinit'.
		static RoundedCornerAdjuster()
		{
			Il2CppClassPointerStore<RoundedCornerAdjuster>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lotus", "RoundedCornerAdjuster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundedCornerAdjuster>.NativeClassPtr);
			RoundedCornerAdjuster.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundedCornerAdjuster>.NativeClassPtr, "position");
			RoundedCornerAdjuster.NativeFieldInfoPtr_useLayoutElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundedCornerAdjuster>.NativeClassPtr, "useLayoutElement");
			RoundedCornerAdjuster.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundedCornerAdjuster>.NativeClassPtr, 100663523);
			RoundedCornerAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundedCornerAdjuster>.NativeClassPtr, 100663524);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00021170 File Offset: 0x0001F370
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundedCornerAdjuster.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000211A4 File Offset: 0x0001F3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497281, XrefRangeEnd = 497282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoundedCornerAdjuster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundedCornerAdjuster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundedCornerAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000026A9 File Offset: 0x000008A9
		public RoundedCornerAdjuster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000211E0 File Offset: 0x0001F3E0
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000026B2 File Offset: 0x000008B2
		public unsafe RoundedCornerAdjuster.RoundedCornerPosition position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundedCornerAdjuster.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundedCornerAdjuster.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00021208 File Offset: 0x0001F408
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000026CD File Offset: 0x000008CD
		public unsafe bool useLayoutElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundedCornerAdjuster.NativeFieldInfoPtr_useLayoutElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundedCornerAdjuster.NativeFieldInfoPtr_useLayoutElement)) = value;
			}
		}

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_useLayoutElement;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D8 RID: 728
		[Serializable]
		public enum RoundedCornerPosition
		{
			// Token: 0x04001589 RID: 5513
			TOP_LEFT,
			// Token: 0x0400158A RID: 5514
			TOP_RIGHT,
			// Token: 0x0400158B RID: 5515
			BOTTOM_RIGHT,
			// Token: 0x0400158C RID: 5516
			BOTTOM_LEFT
		}
	}
}
