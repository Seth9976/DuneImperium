using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace UnityEngine
{
	// Token: 0x02000137 RID: 311
	public class SetupCoroutine : Object
	{
		// Token: 0x0600181E RID: 6174 RVA: 0x000719FC File Offset: 0x0006FBFC
		// Note: this type is marked as 'beforefieldinit'.
		static SetupCoroutine()
		{
			Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SetupCoroutine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr);
			SetupCoroutine.NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr, 100666581);
			SetupCoroutine.NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr, 100666582);
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x00071A54 File Offset: 0x0006FC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664354, XrefRangeEnd = 664359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupCoroutine.NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00071A98 File Offset: 0x0006FC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664359, XrefRangeEnd = 664365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InvokeMember(Object behaviour, string name, Object variable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(behaviour);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(variable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupCoroutine.NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x000098C9 File Offset: 0x00007AC9
		public SetupCoroutine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000098D2 File Offset: 0x00007AD2
		public static Object InvokeStatic(Type klass, string name, Object variable)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0;
	}
}
