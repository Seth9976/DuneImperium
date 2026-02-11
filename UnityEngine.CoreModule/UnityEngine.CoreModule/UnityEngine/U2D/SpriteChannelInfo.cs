using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D
{
	// Token: 0x02000187 RID: 391
	[StructLayout(2)]
	public struct SpriteChannelInfo
	{
		// Token: 0x06001D3F RID: 7487 RVA: 0x00086374 File Offset: 0x00084574
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteChannelInfo()
		{
			Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteChannelInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr);
			SpriteChannelInfo.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, "m_Buffer");
			SpriteChannelInfo.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, "m_Count");
			SpriteChannelInfo.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, "m_Offset");
			SpriteChannelInfo.NativeFieldInfoPtr_m_Stride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, "m_Stride");
			SpriteChannelInfo.NativeMethodInfoPtr_get_buffer_Public_get_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, 100667391);
			SpriteChannelInfo.NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, 100667392);
			SpriteChannelInfo.NativeMethodInfoPtr_get_offset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, 100667393);
			SpriteChannelInfo.NativeMethodInfoPtr_get_stride_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, 100667394);
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00086444 File Offset: 0x00084644
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x0000AEAA File Offset: 0x000090AA
		public unsafe void* buffer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 677451, RefRangeEnd = 677452, XrefRangeStart = 677450, XrefRangeEnd = 677451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteChannelInfo.NativeMethodInfoPtr_get_buffer_Public_get_ptr_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
			set
			{
				this.m_Buffer = (IntPtr)value;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x0008646C File Offset: 0x0008466C
		// (set) Token: 0x06001D46 RID: 7494 RVA: 0x0000AEB9 File Offset: 0x000090B9
		public unsafe int count
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteChannelInfo.NativeMethodInfoPtr_get_count_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Count = value;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x0008649C File Offset: 0x0008469C
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x0000AEC3 File Offset: 0x000090C3
		public unsafe int offset
		{
			[CallerCount(85)]
			[CachedScanResults(RefRangeStart = 643827, RefRangeEnd = 643912, XrefRangeStart = 643827, XrefRangeEnd = 643912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteChannelInfo.NativeMethodInfoPtr_get_offset_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Offset = value;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x000864CC File Offset: 0x000846CC
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x0000AECD File Offset: 0x000090CD
		public unsafe int stride
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 334600, RefRangeEnd = 334642, XrefRangeStart = 334600, XrefRangeEnd = 334642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteChannelInfo.NativeMethodInfoPtr_get_stride_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Stride = value;
			}
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x0000AE98 File Offset: 0x00009098
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeFieldInfoPtr_m_Count;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeFieldInfoPtr_m_Stride;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeMethodInfoPtr_get_buffer_Public_get_ptr_Void_0;

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeMethodInfoPtr_get_offset_Public_get_Int32_0;

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeMethodInfoPtr_get_stride_Public_get_Int32_0;

		// Token: 0x040019F5 RID: 6645
		[FieldOffset(0)]
		public IntPtr m_Buffer;

		// Token: 0x040019F6 RID: 6646
		[FieldOffset(8)]
		public int m_Count;

		// Token: 0x040019F7 RID: 6647
		[FieldOffset(12)]
		public int m_Offset;

		// Token: 0x040019F8 RID: 6648
		[FieldOffset(16)]
		public int m_Stride;
	}
}
