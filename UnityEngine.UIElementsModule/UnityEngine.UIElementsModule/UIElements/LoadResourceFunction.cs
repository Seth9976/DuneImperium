using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200015C RID: 348
	public sealed class LoadResourceFunction : MulticastDelegate
	{
		// Token: 0x06001973 RID: 6515 RVA: 0x000772EC File Offset: 0x000754EC
		// Note: this type is marked as 'beforefieldinit'.
		static LoadResourceFunction()
		{
			Il2CppClassPointerStore<LoadResourceFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "LoadResourceFunction");
			LoadResourceFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadResourceFunction>.NativeClassPtr, 100667043);
			LoadResourceFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_String_Type_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadResourceFunction>.NativeClassPtr, 100667044);
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x0007733C File Offset: 0x0007553C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320752, XrefRangeEnd = 320756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadResourceFunction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadResourceFunction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadResourceFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00077398 File Offset: 0x00075598
		[CallerCount(0)]
		public unsafe Object Invoke(string pathName, Type type, float dpiScaling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pathName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dpiScaling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadResourceFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_String_Type_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x0000B94E File Offset: 0x00009B4E
		public LoadResourceFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0000B957 File Offset: 0x00009B57
		public static implicit operator LoadResourceFunction(Func<string, Type, float, Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<LoadResourceFunction>(A_0);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x0000B95F File Offset: 0x00009B5F
		public static LoadResourceFunction operator +(LoadResourceFunction A_0, LoadResourceFunction A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<LoadResourceFunction>();
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x0000B96D File Offset: 0x00009B6D
		public static LoadResourceFunction operator -(LoadResourceFunction A_0, LoadResourceFunction A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<LoadResourceFunction>();
			}
			return delegate2;
		}

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_String_Type_Single_0;
	}
}
