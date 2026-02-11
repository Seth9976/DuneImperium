using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x02000458 RID: 1112
	[Serializable]
	[StructLayout(2)]
	public struct Label
	{
		// Token: 0x06004111 RID: 16657 RVA: 0x00138280 File Offset: 0x00136480
		// Note: this type is marked as 'beforefieldinit'.
		static Label()
		{
			Il2CppClassPointerStore<Label>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "Label");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Label>.NativeClassPtr);
			Label.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Label>.NativeClassPtr, "label");
			Label.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Label>.NativeClassPtr, 100673152);
			Label.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Label_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Label>.NativeClassPtr, 100673153);
			Label.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Label>.NativeClassPtr, 100673154);
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x00138300 File Offset: 0x00136500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402862, XrefRangeEnd = 1402863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Label.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x00138344 File Offset: 0x00136544
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 555566, RefRangeEnd = 555578, XrefRangeStart = 555566, XrefRangeEnd = 555578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Label obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Label.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Label_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x00138384 File Offset: 0x00136584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Label.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x0001781E File Offset: 0x00015A1E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Label>.NativeClassPtr, ref this));
		}

		// Token: 0x04003595 RID: 13717
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04003596 RID: 13718
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003597 RID: 13719
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Label_0;

		// Token: 0x04003598 RID: 13720
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003599 RID: 13721
		[FieldOffset(0)]
		public readonly int label;
	}
}
