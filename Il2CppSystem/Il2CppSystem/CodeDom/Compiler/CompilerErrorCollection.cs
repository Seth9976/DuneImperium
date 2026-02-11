using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.CodeDom.Compiler
{
	// Token: 0x0200026B RID: 619
	[DefaultMember("Item")]
	[Serializable]
	public class CompilerErrorCollection : CollectionBase
	{
		// Token: 0x0600294C RID: 10572 RVA: 0x000BB7E4 File Offset: 0x000B99E4
		// Note: this type is marked as 'beforefieldinit'.
		static CompilerErrorCollection()
		{
			Il2CppClassPointerStore<CompilerErrorCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.CodeDom.Compiler", "CompilerErrorCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompilerErrorCollection>.NativeClassPtr);
			CompilerErrorCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerErrorCollection>.NativeClassPtr, 100669440);
			CompilerErrorCollection.NativeMethodInfoPtr_Add_Public_Int32_CompilerError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerErrorCollection>.NativeClassPtr, 100669441);
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x000BB83C File Offset: 0x000B9A3C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 494160, RefRangeEnd = 494166, XrefRangeStart = 494157, XrefRangeEnd = 494160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompilerErrorCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilerErrorCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilerErrorCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x000BB878 File Offset: 0x000B9A78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 494169, RefRangeEnd = 494173, XrefRangeStart = 494166, XrefRangeEnd = 494169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(CompilerError value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilerErrorCollection.NativeMethodInfoPtr_Add_Public_Int32_CompilerError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x00011BCC File Offset: 0x0000FDCC
		public CompilerErrorCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020CB RID: 8395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020CC RID: 8396
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_CompilerError_0;
	}
}
