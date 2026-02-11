using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200001F RID: 31
	public class OutPt : Object
	{
		// Token: 0x0600013C RID: 316 RVA: 0x000193A0 File Offset: 0x000175A0
		// Note: this type is marked as 'beforefieldinit'.
		static OutPt()
		{
			Il2CppClassPointerStore<OutPt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "OutPt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutPt>.NativeClassPtr);
			OutPt.NativeFieldInfoPtr_Idx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutPt>.NativeClassPtr, "Idx");
			OutPt.NativeFieldInfoPtr_Pt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutPt>.NativeClassPtr, "Pt");
			OutPt.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutPt>.NativeClassPtr, "Next");
			OutPt.NativeFieldInfoPtr_Prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutPt>.NativeClassPtr, "Prev");
			OutPt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutPt>.NativeClassPtr, 100663435);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00019434 File Offset: 0x00017634
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutPt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutPt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutPt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002A33 File Offset: 0x00000C33
		public OutPt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00019470 File Offset: 0x00017670
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002A3C File Offset: 0x00000C3C
		public unsafe int Idx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutPt.NativeFieldInfoPtr_Idx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutPt.NativeFieldInfoPtr_Idx)) = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00019498 File Offset: 0x00017698
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002A57 File Offset: 0x00000C57
		public unsafe IntPoint Pt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutPt.NativeFieldInfoPtr_Pt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutPt.NativeFieldInfoPtr_Pt)) = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000194C0 File Offset: 0x000176C0
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002A72 File Offset: 0x00000C72
		public unsafe OutPt Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutPt.NativeFieldInfoPtr_Next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OutPt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutPt.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000194F0 File Offset: 0x000176F0
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002A91 File Offset: 0x00000C91
		public unsafe OutPt Prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutPt.NativeFieldInfoPtr_Prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OutPt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutPt.NativeFieldInfoPtr_Prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_Idx;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_Pt;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_Next;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_Prev;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
