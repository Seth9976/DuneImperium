using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000003 RID: 3
	public sealed class Logger : MulticastDelegate
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0001CC20 File Offset: 0x0001AE20
		// Note: this type is marked as 'beforefieldinit'.
		static Logger()
		{
			Il2CppClassPointerStore<Logger>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.Yoga", "Logger");
			Logger.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663299);
			Logger.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YogaConfig_YogaNode_YogaLogLevel_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663300);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0001CC70 File Offset: 0x0001AE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282387, XrefRangeEnd = 282396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Logger(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Logger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0001CCCC File Offset: 0x0001AECC
		[CallerCount(0)]
		public unsafe void Invoke(YogaConfig config, YogaNode node, YogaLogLevel level, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YogaConfig_YogaNode_YogaLogLevel_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002080 File Offset: 0x00000280
		public Logger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002089 File Offset: 0x00000289
		public static implicit operator Logger(Action<YogaConfig, YogaNode, YogaLogLevel, string> A_0)
		{
			return DelegateSupport.ConvertDelegate<Logger>(A_0);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002091 File Offset: 0x00000291
		public static Logger operator +(Logger A_0, Logger A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Logger>();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000209F File Offset: 0x0000029F
		public static Logger operator -(Logger A_0, Logger A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Logger>();
			}
			return delegate2;
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YogaConfig_YogaNode_YogaLogLevel_String_0;
	}
}
