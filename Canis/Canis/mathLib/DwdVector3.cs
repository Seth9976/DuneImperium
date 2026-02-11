using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.mathLib
{
	// Token: 0x02000076 RID: 118
	[Serializable]
	[StructLayout(2)]
	public struct DwdVector3
	{
		// Token: 0x0600066D RID: 1645 RVA: 0x00032FE4 File Offset: 0x000311E4
		// Note: this type is marked as 'beforefieldinit'.
		static DwdVector3()
		{
			Il2CppClassPointerStore<DwdVector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "DwdVector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdVector3>.NativeClassPtr);
			DwdVector3.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdVector3>.NativeClassPtr, "X");
			DwdVector3.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdVector3>.NativeClassPtr, "Y");
			DwdVector3.NativeFieldInfoPtr_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdVector3>.NativeClassPtr, "Z");
			DwdVector3.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector3>.NativeClassPtr, 100664624);
			DwdVector3.NativeMethodInfoPtr_DotProduct_Public_Int32_DwdVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector3>.NativeClassPtr, 100664625);
			DwdVector3.NativeMethodInfoPtr_CrossProduct_Public_DwdVector3_DwdVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector3>.NativeClassPtr, 100664626);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0003308C File Offset: 0x0003128C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 556229, RefRangeEnd = 556238, XrefRangeStart = 556229, XrefRangeEnd = 556229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdVector3(int x, int y, int z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector3.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x000330DC File Offset: 0x000312DC
		[CallerCount(0)]
		public unsafe int DotProduct(DwdVector3 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector3.NativeMethodInfoPtr_DotProduct_Public_Int32_DwdVector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0003311C File Offset: 0x0003131C
		[CallerCount(0)]
		public unsafe DwdVector3 CrossProduct(DwdVector3 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector3.NativeMethodInfoPtr_CrossProduct_Public_DwdVector3_DwdVector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00004986 File Offset: 0x00002B86
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DwdVector3>.NativeClassPtr, ref this));
		}

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_Z;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_DotProduct_Public_Int32_DwdVector3_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_CrossProduct_Public_DwdVector3_DwdVector3_0;

		// Token: 0x0400044E RID: 1102
		[FieldOffset(0)]
		public readonly int X;

		// Token: 0x0400044F RID: 1103
		[FieldOffset(4)]
		public readonly int Y;

		// Token: 0x04000450 RID: 1104
		[FieldOffset(8)]
		public readonly int Z;
	}
}
