using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace JsonFx.Serialization
{
	// Token: 0x0200000B RID: 11
	public class ITokenAnalyzer : Il2CppObjectBase
	{
		// Token: 0x06000053 RID: 83 RVA: 0x0000502C File Offset: 0x0000322C
		// Note: this type is marked as 'beforefieldinit'.
		static ITokenAnalyzer()
		{
			Il2CppClassPointerStore<ITokenAnalyzer>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "ITokenAnalyzer");
			ITokenAnalyzer.NativeMethodInfoPtr_get_Settings_Public_Abstract_Virtual_New_get_DataReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITokenAnalyzer>.NativeClassPtr, 100663343);
			ITokenAnalyzer.NativeMethodInfoPtr_Analyze_Public_Abstract_Virtual_New_Object_IEnumerable_1_Token_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITokenAnalyzer>.NativeClassPtr, 100663344);
			ITokenAnalyzer.NativeMethodInfoPtr_Analyze_Public_Abstract_Virtual_New_TResult_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITokenAnalyzer>.NativeClassPtr, 100663345);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00005090 File Offset: 0x00003290
		public unsafe virtual DataReaderSettings Settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITokenAnalyzer.NativeMethodInfoPtr_get_Settings_Public_Abstract_Virtual_New_get_DataReaderSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000050DC File Offset: 0x000032DC
		[CallerCount(0)]
		public unsafe virtual Object Analyze(IEnumerable<Token> tokens, Type targetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITokenAnalyzer.NativeMethodInfoPtr_Analyze_Public_Abstract_Virtual_New_Object_IEnumerable_1_Token_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000514C File Offset: 0x0000334C
		[CallerCount(0)]
		public unsafe virtual TResult Analyze<TResult>(IEnumerable<Token> tokens)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITokenAnalyzer.MethodInfoStoreGeneric_Analyze_Public_Abstract_Virtual_New_TResult_IEnumerable_1_Token_0<TResult>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002206 File Offset: 0x00000406
		public ITokenAnalyzer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_Abstract_Virtual_New_get_DataReaderSettings_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Abstract_Virtual_New_Object_IEnumerable_1_Token_Type_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Abstract_Virtual_New_TResult_IEnumerable_1_Token_0;

		// Token: 0x0200003C RID: 60
		private sealed class MethodInfoStoreGeneric_Analyze_Public_Abstract_Virtual_New_TResult_IEnumerable_1_Token_0<TResult>
		{
			// Token: 0x04000218 RID: 536
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ITokenAnalyzer.NativeMethodInfoPtr_Analyze_Public_Abstract_Virtual_New_TResult_IEnumerable_1_Token_0, Il2CppClassPointerStore<ITokenAnalyzer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}
