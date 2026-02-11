using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dbgclient.voodoo.layout
{
	// Token: 0x0200008C RID: 140
	public class TransformLayoutElement : MonoBehaviour
	{
		// Token: 0x06000582 RID: 1410 RVA: 0x0002F050 File Offset: 0x0002D250
		// Note: this type is marked as 'beforefieldinit'.
		static TransformLayoutElement()
		{
			Il2CppClassPointerStore<TransformLayoutElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.voodoo.layout", "TransformLayoutElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformLayoutElement>.NativeClassPtr);
			TransformLayoutElement.NativeFieldInfoPtr_parentLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformLayoutElement>.NativeClassPtr, "parentLayout");
			TransformLayoutElement.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformLayoutElement>.NativeClassPtr, 100664134);
			TransformLayoutElement.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformLayoutElement>.NativeClassPtr, 100664135);
			TransformLayoutElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformLayoutElement>.NativeClassPtr, 100664136);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0002F0D0 File Offset: 0x0002D2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501886, XrefRangeEnd = 501897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformLayoutElement.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0002F104 File Offset: 0x0002D304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501897, XrefRangeEnd = 501901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformLayoutElement.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0002F138 File Offset: 0x0002D338
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformLayoutElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformLayoutElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformLayoutElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000047B6 File Offset: 0x000029B6
		public TransformLayoutElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0002F174 File Offset: 0x0002D374
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x000047BF File Offset: 0x000029BF
		public unsafe TransformLayout parentLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLayoutElement.NativeFieldInfoPtr_parentLayout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransformLayout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLayoutElement.NativeFieldInfoPtr_parentLayout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeFieldInfoPtr_parentLayout;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
