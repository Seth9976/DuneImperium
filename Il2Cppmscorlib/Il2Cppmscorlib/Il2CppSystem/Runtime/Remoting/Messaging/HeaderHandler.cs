using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002F9 RID: 761
	public sealed class HeaderHandler : MulticastDelegate
	{
		// Token: 0x06002F07 RID: 12039 RVA: 0x000F21B0 File Offset: 0x000F03B0
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderHandler()
		{
			Il2CppClassPointerStore<HeaderHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "HeaderHandler");
			HeaderHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderHandler>.NativeClassPtr, 100670763);
			HeaderHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Il2CppReferenceArray_1_Header_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderHandler>.NativeClassPtr, 100670764);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x000F2200 File Offset: 0x000F0400
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 554431, RefRangeEnd = 554456, XrefRangeStart = 554431, XrefRangeEnd = 554456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x000F225C File Offset: 0x000F045C
		[CallerCount(0)]
		public unsafe Object Invoke(Il2CppReferenceArray<Header> headers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(headers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Il2CppReferenceArray_1_Header_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x0001000D File Offset: 0x0000E20D
		public HeaderHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x00010016 File Offset: 0x0000E216
		public static implicit operator HeaderHandler(Func<Il2CppReferenceArray<Header>, Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<HeaderHandler>(A_0);
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x0001001E File Offset: 0x0000E21E
		public static HeaderHandler operator +(HeaderHandler A_0, HeaderHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<HeaderHandler>();
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x0001002C File Offset: 0x0000E22C
		public static HeaderHandler operator -(HeaderHandler A_0, HeaderHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<HeaderHandler>();
			}
			return delegate2;
		}

		// Token: 0x04002718 RID: 10008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002719 RID: 10009
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Il2CppReferenceArray_1_Header_0;
	}
}
