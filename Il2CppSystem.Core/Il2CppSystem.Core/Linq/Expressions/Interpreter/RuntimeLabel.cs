using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000096 RID: 150
	[StructLayout(2)]
	public struct RuntimeLabel
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x00034BDC File Offset: 0x00032DDC
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeLabel()
		{
			Il2CppClassPointerStore<RuntimeLabel>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "RuntimeLabel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeLabel>.NativeClassPtr);
			RuntimeLabel.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeLabel>.NativeClassPtr, "Index");
			RuntimeLabel.NativeFieldInfoPtr_StackDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeLabel>.NativeClassPtr, "StackDepth");
			RuntimeLabel.NativeFieldInfoPtr_ContinuationStackDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeLabel>.NativeClassPtr, "ContinuationStackDepth");
			RuntimeLabel.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeLabel>.NativeClassPtr, 100664878);
			RuntimeLabel.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeLabel>.NativeClassPtr, 100664879);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00034C70 File Offset: 0x00032E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1015696, RefRangeEnd = 1015697, XrefRangeStart = 1015696, XrefRangeEnd = 1015696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeLabel(int index, int continuationStackDepth, int stackDepth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationStackDepth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stackDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeLabel.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00034CC0 File Offset: 0x00032EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015697, XrefRangeEnd = 1015711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeLabel.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000042AD File Offset: 0x000024AD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeLabel>.NativeClassPtr, ref this));
		}

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeFieldInfoPtr_Index;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeFieldInfoPtr_StackDepth;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeFieldInfoPtr_ContinuationStackDepth;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000659 RID: 1625
		[FieldOffset(0)]
		public readonly int Index;

		// Token: 0x0400065A RID: 1626
		[FieldOffset(4)]
		public readonly int StackDepth;

		// Token: 0x0400065B RID: 1627
		[FieldOffset(8)]
		public readonly int ContinuationStackDepth;
	}
}
