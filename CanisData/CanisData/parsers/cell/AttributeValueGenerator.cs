using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace CanisData.parsers.cell
{
	// Token: 0x02000013 RID: 19
	public sealed class AttributeValueGenerator : MulticastDelegate
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00005584 File Offset: 0x00003784
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeValueGenerator()
		{
			Il2CppClassPointerStore<AttributeValueGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "AttributeValueGenerator");
			AttributeValueGenerator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerator>.NativeClassPtr, 100663359);
			AttributeValueGenerator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_String_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerator>.NativeClassPtr, 100663360);
			AttributeValueGenerator.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ScriptBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerator>.NativeClassPtr, 100663361);
			AttributeValueGenerator.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerator>.NativeClassPtr, 100663362);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000055FC File Offset: 0x000037FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 426990, RefRangeEnd = 426992, XrefRangeStart = 426990, XrefRangeEnd = 426992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeValueGenerator(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeValueGenerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00005658 File Offset: 0x00003858
		[CallerCount(0)]
		public unsafe string Invoke(string cell, ScriptBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cell);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_String_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000056B4 File Offset: 0x000038B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(string cell, ScriptBuilder builder, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cell);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerator.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ScriptBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000573C File Offset: 0x0000393C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerator.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002457 File Offset: 0x00000657
		public AttributeValueGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002460 File Offset: 0x00000660
		public static implicit operator AttributeValueGenerator(Func<string, ScriptBuilder, string> A_0)
		{
			return DelegateSupport.ConvertDelegate<AttributeValueGenerator>(A_0);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002468 File Offset: 0x00000668
		public static AttributeValueGenerator operator +(AttributeValueGenerator A_0, AttributeValueGenerator A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AttributeValueGenerator>();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002476 File Offset: 0x00000676
		public static AttributeValueGenerator operator -(AttributeValueGenerator A_0, AttributeValueGenerator A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AttributeValueGenerator>();
			}
			return delegate2;
		}

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_String_ScriptBuilder_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ScriptBuilder_AsyncCallback_Object_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_String_IAsyncResult_0;
	}
}
