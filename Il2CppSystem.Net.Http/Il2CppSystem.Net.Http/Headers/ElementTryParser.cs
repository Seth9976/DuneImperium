using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x0200001A RID: 26
	public sealed class ElementTryParser<T> : MulticastDelegate
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x0000AF04 File Offset: 0x00009104
		// Note: this type is marked as 'beforefieldinit'.
		static ElementTryParser()
		{
			Il2CppClassPointerStore<ElementTryParser<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "ElementTryParser`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			ElementTryParser<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementTryParser<T>>.NativeClassPtr, 100663547);
			ElementTryParser<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Lexer_byref_T_byref_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementTryParser<T>>.NativeClassPtr, 100663548);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000AF90 File Offset: 0x00009190
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1173102, RefRangeEnd = 1173114, XrefRangeStart = 1173093, XrefRangeEnd = 1173102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElementTryParser(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElementTryParser<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementTryParser<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000AFEC File Offset: 0x000091EC
		[CallerCount(0)]
		public unsafe bool Invoke(Lexer lexer, out T parsedValue, out Token token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lexer);
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
				intPtr2 = ref parsedValue;
			}
			ptr2 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &token;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ElementTryParser<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Lexer_byref_T_byref_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				parsedValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002B92 File Offset: 0x00000D92
		public ElementTryParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Lexer_byref_T_byref_Token_0;
	}
}
