using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000020 RID: 32
	public sealed class TryParseDelegate<T> : MulticastDelegate
	{
		// Token: 0x06000206 RID: 518 RVA: 0x0000C17C File Offset: 0x0000A37C
		// Note: this type is marked as 'beforefieldinit'.
		static TryParseDelegate()
		{
			Il2CppClassPointerStore<TryParseDelegate<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "TryParseDelegate`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			TryParseDelegate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryParseDelegate<T>>.NativeClassPtr, 100663587);
			TryParseDelegate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryParseDelegate<T>>.NativeClassPtr, 100663588);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000C208 File Offset: 0x0000A408
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 283310, RefRangeEnd = 283333, XrefRangeStart = 283310, XrefRangeEnd = 283333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TryParseDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TryParseDelegate<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryParseDelegate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000C264 File Offset: 0x0000A464
		[CallerCount(0)]
		public unsafe bool Invoke(string value, out T result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref result;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TryParseDelegate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002D34 File Offset: 0x00000F34
		public TryParseDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_byref_T_0;
	}
}
