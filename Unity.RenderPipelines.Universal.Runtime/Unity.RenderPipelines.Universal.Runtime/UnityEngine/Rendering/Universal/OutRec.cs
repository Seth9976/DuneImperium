using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200001E RID: 30
	public class OutRec : Object
	{
		// Token: 0x0600012B RID: 299 RVA: 0x0001915C File Offset: 0x0001735C
		// Note: this type is marked as 'beforefieldinit'.
		static OutRec()
		{
			Il2CppClassPointerStore<OutRec>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "OutRec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutRec>.NativeClassPtr);
			OutRec.NativeFieldInfoPtr_Idx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutRec>.NativeClassPtr, "Idx");
			OutRec.NativeFieldInfoPtr_IsHole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutRec>.NativeClassPtr, "IsHole");
			OutRec.NativeFieldInfoPtr_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutRec>.NativeClassPtr, "IsOpen");
			OutRec.NativeFieldInfoPtr_FirstLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutRec>.NativeClassPtr, "FirstLeft");
			OutRec.NativeFieldInfoPtr_Pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutRec>.NativeClassPtr, "Pts");
			OutRec.NativeFieldInfoPtr_BottomPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutRec>.NativeClassPtr, "BottomPt");
			OutRec.NativeFieldInfoPtr_PolyNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutRec>.NativeClassPtr, "PolyNode");
			OutRec.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutRec>.NativeClassPtr, 100663434);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0001922C File Offset: 0x0001742C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutRec()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutRec>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutRec.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000295D File Offset: 0x00000B5D
		public OutRec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00019268 File Offset: 0x00017468
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002966 File Offset: 0x00000B66
		public unsafe int Idx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_Idx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_Idx)) = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00019290 File Offset: 0x00017490
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00002981 File Offset: 0x00000B81
		public unsafe bool IsHole
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_IsHole);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_IsHole)) = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000192B8 File Offset: 0x000174B8
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0000299C File Offset: 0x00000B9C
		public unsafe bool IsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_IsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_IsOpen)) = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000192E0 File Offset: 0x000174E0
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000029B7 File Offset: 0x00000BB7
		public unsafe OutRec FirstLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_FirstLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OutRec>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_FirstLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00019310 File Offset: 0x00017510
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000029D6 File Offset: 0x00000BD6
		public unsafe OutPt Pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_Pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OutPt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_Pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00019340 File Offset: 0x00017540
		// (set) Token: 0x06000139 RID: 313 RVA: 0x000029F5 File Offset: 0x00000BF5
		public unsafe OutPt BottomPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_BottomPt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OutPt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_BottomPt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00019370 File Offset: 0x00017570
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00002A14 File Offset: 0x00000C14
		public unsafe PolyNode PolyNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_PolyNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolyNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutRec.NativeFieldInfoPtr_PolyNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_Idx;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_IsHole;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_IsOpen;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_FirstLeft;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_Pts;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_BottomPt;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_PolyNode;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
