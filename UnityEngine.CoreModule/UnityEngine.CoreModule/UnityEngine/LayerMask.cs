using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000142 RID: 322
	[StructLayout(2)]
	public struct LayerMask
	{
		// Token: 0x060018BB RID: 6331 RVA: 0x0007479C File Offset: 0x0007299C
		// Note: this type is marked as 'beforefieldinit'.
		static LayerMask()
		{
			Il2CppClassPointerStore<LayerMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LayerMask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerMask>.NativeClassPtr);
			LayerMask.NativeFieldInfoPtr_m_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, "m_Mask");
			LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100666699);
			LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100666700);
			LayerMask.NativeMethodInfoPtr_get_value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100666701);
			LayerMask.NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100666702);
			LayerMask.LayerToNameDelegateField = IL2CPP.ResolveICall<LayerMask.LayerToNameDelegate>("UnityEngine.LayerMask::LayerToName");
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00074840 File Offset: 0x00072A40
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 328435, RefRangeEnd = 328482, XrefRangeStart = 328435, XrefRangeEnd = 328482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator int(LayerMask mask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mask;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00074880 File Offset: 0x00072A80
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 328435, RefRangeEnd = 328482, XrefRangeStart = 328435, XrefRangeEnd = 328482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator LayerMask(int intVal)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intVal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x000748C0 File Offset: 0x00072AC0
		// (set) Token: 0x060018C1 RID: 6337 RVA: 0x00009B56 File Offset: 0x00007D56
		public unsafe int value
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_get_value_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Mask = value;
			}
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x000748F0 File Offset: 0x00072AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 666398, RefRangeEnd = 666400, XrefRangeStart = 666396, XrefRangeEnd = 666398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NameToLayer(string layerName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(layerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00009B44 File Offset: 0x00007D44
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, ref this));
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00074934 File Offset: 0x00072B34
		public static string LayerToName(int layer)
		{
			IntPtr intPtr = LayerMask.LayerToNameDelegateField(layer);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00009B60 File Offset: 0x00007D60
		public static int GetMask(Il2CppStringArray layerNames)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00009B6D File Offset: 0x00007D6D
		public static int GetMask(params string[] layerNames)
		{
			return LayerMask.GetMask(new Il2CppStringArray(layerNames));
		}

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeFieldInfoPtr_m_Mask;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Int32_0;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0;

		// Token: 0x0400161D RID: 5661
		[FieldOffset(0)]
		public int m_Mask;

		// Token: 0x0400161E RID: 5662
		private static readonly LayerMask.LayerToNameDelegate LayerToNameDelegateField;

		// Token: 0x02000752 RID: 1874
		// (Invoke) Token: 0x06003769 RID: 14185
		private delegate IntPtr LayerToNameDelegate(int layer);
	}
}
