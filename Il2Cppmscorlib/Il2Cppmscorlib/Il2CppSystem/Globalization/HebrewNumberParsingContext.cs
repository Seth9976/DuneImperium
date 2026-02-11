using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000476 RID: 1142
	[StructLayout(2)]
	public struct HebrewNumberParsingContext
	{
		// Token: 0x06004510 RID: 17680 RVA: 0x00144564 File Offset: 0x00142764
		// Note: this type is marked as 'beforefieldinit'.
		static HebrewNumberParsingContext()
		{
			Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "HebrewNumberParsingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr);
			HebrewNumberParsingContext.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, "state");
			HebrewNumberParsingContext.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, "result");
			HebrewNumberParsingContext.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, 100673459);
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x001445D0 File Offset: 0x001427D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1408815, RefRangeEnd = 1408816, XrefRangeStart = 1408815, XrefRangeEnd = 1408815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HebrewNumberParsingContext(int result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumberParsingContext.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x000190F8 File Offset: 0x000172F8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, ref this));
		}

		// Token: 0x040038FC RID: 14588
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040038FD RID: 14589
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x040038FE RID: 14590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040038FF RID: 14591
		[FieldOffset(0)]
		public HebrewNumber.HS state;

		// Token: 0x04003900 RID: 14592
		[FieldOffset(4)]
		public int result;
	}
}
