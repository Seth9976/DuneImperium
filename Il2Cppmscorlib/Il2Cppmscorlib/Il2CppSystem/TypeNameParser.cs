using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x02000144 RID: 324
	public sealed class TypeNameParser : Object
	{
		// Token: 0x0600167F RID: 5759 RVA: 0x00006FF0 File Offset: 0x000051F0
		// Note: this type is marked as 'beforefieldinit'.
		static TypeNameParser()
		{
			Il2CppClassPointerStore<TypeNameParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeNameParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeNameParser>.NativeClassPtr);
			TypeNameParser.NativeMethodInfoPtr_GetType_Internal_Static_Type_String_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameParser>.NativeClassPtr, 100667283);
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00092508 File Offset: 0x00090708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1344834, RefRangeEnd = 1344835, XrefRangeStart = 1344831, XrefRangeEnd = 1344834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyResolver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeResolver);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNameParser.NativeMethodInfoPtr_GetType_Internal_Static_Type_String_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00007029 File Offset: 0x00005229
		public TypeNameParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Internal_Static_Type_String_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_byref_StackCrawlMark_0;
	}
}
