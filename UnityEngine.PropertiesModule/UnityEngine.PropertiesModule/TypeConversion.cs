using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x0200005A RID: 90
	public static class TypeConversion
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x0000845C File Offset: 0x0000665C
		public static TDestination Convert<TSource, TDestination>(ref TSource value)
		{
			TDestination tdestination;
			bool flag = !TypeConversion.TryConvert<TSource, TDestination>(ref value, out tdestination);
			if (flag)
			{
				throw new InvalidOperationException(String.Format("TypeConversion no converter has been registered for SrcType=[{0}] to DstType=[{1}]", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TSource>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TDestination>())));
			}
			return tdestination;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000030AC File Offset: 0x000012AC
		public static bool TryConvert<TSource, TDestination>(ref TSource source, out TDestination destination)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000030B9 File Offset: 0x000012B9
		public static bool TryConvertToUnityEngineObject<TSource, TDestination>(TSource source, out TDestination destination)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000084A4 File Offset: 0x000066A4
		public static bool IsNumericType(Type t)
		{
			TypeCode typeCode = Type.GetTypeCode(t);
			TypeCode typeCode2 = typeCode;
			return typeCode2 - TypeCode.SByte <= 10;
		}

		// Token: 0x020000B2 RID: 178
		public static class PrimitiveConverters
		{
			// Token: 0x020000B7 RID: 183
			[Serializable]
			public sealed class <>c
			{
			}
		}
	}
}
