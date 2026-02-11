using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001CC RID: 460
	public sealed class HeaderParser : MulticastDelegate
	{
		// Token: 0x06001C6F RID: 7279 RVA: 0x0008B324 File Offset: 0x00089524
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderParser()
		{
			Il2CppClassPointerStore<HeaderParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HeaderParser");
			HeaderParser.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderParser>.NativeClassPtr, 100667666);
			HeaderParser.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderParser>.NativeClassPtr, 100667667);
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0008B374 File Offset: 0x00089574
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 427006, RefRangeEnd = 427011, XrefRangeStart = 427006, XrefRangeEnd = 427011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderParser(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderParser.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0008B3D0 File Offset: 0x000895D0
		[CallerCount(0)]
		public unsafe Il2CppStringArray Invoke(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderParser.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0000C13B File Offset: 0x0000A33B
		public HeaderParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0000C144 File Offset: 0x0000A344
		public static implicit operator HeaderParser(Func<string, Il2CppStringArray> A_0)
		{
			return DelegateSupport.ConvertDelegate<HeaderParser>(A_0);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0000C14C File Offset: 0x0000A34C
		public static HeaderParser operator +(HeaderParser A_0, HeaderParser A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<HeaderParser>();
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0000C15A File Offset: 0x0000A35A
		public static HeaderParser operator -(HeaderParser A_0, HeaderParser A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<HeaderParser>();
			}
			return delegate2;
		}

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStringArray_String_0;
	}
}
